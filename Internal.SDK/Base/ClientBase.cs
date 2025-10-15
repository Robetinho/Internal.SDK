using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;

namespace Internal.SDK.Base
{
    public abstract class ClientBase
    {
        private readonly string _domain;
        private readonly string _root;
        private readonly HttpClient _httpClient;

        internal ClientBase(string domain, string root, HttpClient? httpClient = null)
        {
            _domain = domain;
            _root = root;
            _httpClient = httpClient ?? new HttpClient();
        }

        internal HttpRequestMessage GetBaseRequest(HttpMethod httpMethod, string path, string body, string queryString)
        {
            var url = $"{_domain.TrimEnd('/')}/{_root.TrimEnd('/')}/{path.TrimStart('/')}{queryString}";
            var request = new HttpRequestMessage(httpMethod, url);

            request.Headers.Add("x-cpapi-version", "v2");

            request.Content = new StringContent(body);
            request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            return request;
        }

        internal async Task<Response<T>> GetPostResponse<T>(string path, object payload)
        {
            string json = string.Empty;

            try
            {
                json = JsonSerializer.Serialize(payload);
            }
            catch (JsonException ex)
            {
                return new Response<T>
                {
                    IsSuccess = false
                };
            }

            return await GetResponse<T>(HttpMethod.Post, path, json, string.Empty);
        }


        internal async Task<Response<T>> GetResponse<T>(HttpMethod httpMethod, string path, string body, string queryString)
        {
            var request = GetBaseRequest(httpMethod, path, body, queryString);

            HttpResponseMessage response = await _httpClient.SendAsync(request);

            var result = new Response<T>();
            result.Item = await response?.Content?.ReadFromJsonAsync<T>();
            return result;
        }
    }

}
