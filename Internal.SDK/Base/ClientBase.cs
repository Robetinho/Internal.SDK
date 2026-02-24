using Internal.SDK.SystemLogger;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Internal.SDK.Base
{
    public abstract class ClientBase
    {
        private readonly string key = @"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";
        private readonly string _domain;
        private readonly string _root;
        private readonly HttpClient _httpClient;
        internal readonly ISystemLoggerClient? _systemLoggerClient;

        internal ClientBase(string domain, string root, HttpClient? httpClient = null, ISystemLoggerClient? systemLoggerClient = null)
        {
            _domain = domain;
            _root = root;
            _httpClient = httpClient ?? new HttpClient();
            _systemLoggerClient = systemLoggerClient;
        }

        internal HttpRequestMessage GetBaseRequest(HttpMethod httpMethod, string path, string body, string queryString)
        {
            var url = $"{_domain.TrimEnd('/')}/{_root.TrimEnd('/')}/{path.TrimStart('/')}{queryString}";
            var request = new HttpRequestMessage(httpMethod, url);

            request.Headers.Add("x-py-sys-api-version", "v2");

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


            Console.WriteLine("GetResponse hit");

            var request = GetBaseRequest(httpMethod, path, body, queryString);




            var result = new Response<T>
            {
                _httpMethod = httpMethod,
                _path = path,
                _body = body,
                _queryString = queryString,
                _clientBase = this
            };

            try
            {
                HttpResponseMessage response = await _httpClient.SendAsync(request);


                result.IsSuccess = response.IsSuccessStatusCode;

                result.ResponseCode = (int)response.StatusCode;
                if (result.IsSuccess)
                {
                    result.Item = await response.Content.ReadFromJsonAsync<T>();
                }
                else 
                {
                    var json = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("json error resonse:" + json);
                    var doc = JsonDocument.Parse(json);
                     
                    var typeName = doc.RootElement.GetProperty("type").GetString();
                    var targetType = Type.GetType(typeName!) ?? typeof(Exception);

                    Console.WriteLine("targetType:" + targetType.ToString());
                    var detailsJson = doc.RootElement.GetProperty("details").GetRawText();
                     
                    result.Error = (Exception)JsonSerializer.Deserialize(detailsJson, targetType)!;
                }
            }
            catch (Exception ex)
            {
                result.Error = ex;
                 
                result.IsSuccess = false;

                if (_systemLoggerClient != null)
                {
                    _systemLoggerClient.LogAlert($"An error occured when calling the following network call: {httpMethod} {path} Body: {body} QueryString: {queryString} Exception: {ex.Message}", ex.StackTrace);
                }
            }

            return result;
        }
    }

}
