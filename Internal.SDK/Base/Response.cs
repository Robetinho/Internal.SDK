using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Internal.SDK.Base
{
    public class Response<T>
    {
        public T? Item { get; set; }

        public bool IsSuccess { get; set; }

        public int ResponseCode { get; set; }

        // Retry functionality
        internal HttpMethod? _httpMethod { get; init; }

        internal string? _path { get; init; }

        internal string? _body { get; init; }

        internal string? _queryString { get; init; }

        internal ClientBase? _clientBase { get; init; } 

        public async Task<Response<T>> RetryIfFailed(int retryAttemps = 1, int waitTime = 100)
        {
            if (this.IsSuccess)
            {
                return this;
            } 
             
            Response<T> lastResponse = this;
            
            for (int attempt = 0; attempt < retryAttemps; attempt++)
            {
                await Task.Delay(waitTime);
                
                lastResponse = await _clientBase!.GetResponse<T>(_httpMethod!, _path!, _body!, _queryString!);
                
                if (lastResponse.IsSuccess)
                {
                    return lastResponse;
                }
            }
            
            return lastResponse;
        } 
    } 
}
