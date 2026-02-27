using Internal.SDK.AISession;
using Internal.SDK.SystemLogger;
using System;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Internal.SDK.Base
{

    

    // Add a generic type constraint to ensure TError is ServiceError or a derived type
    public abstract class ClientBase<TError> where TError : ServiceError 
    { 
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

        internal async Task<Response<T, TError>> GetPostResponse<T>(string path, object payload)
        {
            string json = string.Empty;

            try
            {
                json = JsonSerializer.Serialize(payload);
            }
            catch (JsonException ex)
            {
                return new Response<T, TError>
                {
                    IsSuccess = false
                };
            }

            return await GetResponse<T>(HttpMethod.Post, path, json, string.Empty);
        }


        internal async Task<Response<T, TError>> GetResponse<T>(HttpMethod httpMethod, string path, string body, string queryString)
        {
             
            Console.WriteLine("GetResponse hit");

            var request = GetBaseRequest(httpMethod, path, body, queryString);
             
            var result = new Response<T, TError>
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


                var contentBody = await response.Content.ReadAsStringAsync();

                // <-- Print it so you can see exactly what the server returned
                Console.WriteLine("Response body:");
                Console.WriteLine(contentBody);
                 

                Console.WriteLine("Response content: " + response.Content);
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


                    Console.WriteLine("serialised value = " + detailsJson);
                    //var asdf = JsonSerializer.Deserialize(detailsJson, targetType);

                    //var sdf = Type.GetType(typeName);

                    //Type errorType = Type.GetType(typeName!) ?? typeof(Exception);

                    // var asdf = JsonSerializer.Deserialize(detailsJson, targetType);

                    // var asdfa =  JsonSerializer.Deserialize(detailsJson, targetType) as errorType;
                    var dasdfobj =  JsonSerializer.Deserialize(detailsJson, targetType, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    })!;

                    Console.WriteLine("reserialised value = " + JsonSerializer.Serialize(dasdfobj)!);
                    var dasdf = (TError)dasdfobj;

                    Console.WriteLine("reserialised object = " + JsonSerializer.Serialize(dasdf)!);
                    result.Error =  dasdf;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("exception thrown");  
                
                result.Error = ex as TError;  
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
