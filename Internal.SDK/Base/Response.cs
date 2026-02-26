namespace Internal.SDK.Base
{
    public class Response<TResult, TError> where TError : ServiceError
    {
        public TResult? Item { get; set; }

        public bool IsSuccess { get; set; }

        public int ResponseCode { get; set; }

        // Retry functionality
        internal HttpMethod? _httpMethod { get; init; }

        internal string? _path { get; init; }

        internal string? _body { get; init; }

        internal string? _queryString { get; init; }

        internal ClientBase<TError>? _clientBase { get; init; }
         
        public TError? Error { get; set; }
         

        public async Task RetryIfFailed(int retryAttemps = 1, int waitTime = 100)
        {
            if (!this.IsSuccess)
            {

                Response<TResult, TError> lastResponse = this;

                for (int attempt = 0; attempt < retryAttemps; attempt++)
                {
                    await Task.Delay(waitTime);

                    lastResponse = await _clientBase!.GetResponse<TResult>(_httpMethod!, _path!, _body!, _queryString!);

                    if (lastResponse.IsSuccess)
                    {
                        if (_clientBase._systemLoggerClient != null)
                        {
                            _clientBase._systemLoggerClient.LogAlert($"The retry attemp of the call: {_httpMethod!} {_path} Body: {_body} QueryString: {_queryString} executed successfully");
                        }
                        break;
                    }
                }

                this.Item = lastResponse.Item;
                this.IsSuccess = lastResponse.IsSuccess;
                this.ResponseCode = lastResponse.ResponseCode;
            }
        }
    }
}
