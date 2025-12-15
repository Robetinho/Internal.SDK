using Internal.SDK.Base;
using Internal.SDK.SystemLogger.DTOs;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Http;

namespace Internal.SDK.SystemLogger
{

    public class SystemLoggerClient : ClientBase, ISystemLoggerClient
    {

        private readonly string _applicationName;

        public SystemLoggerClient(IHostEnvironment hostEnvironment, HttpClient httpClient) : base("http://localhost:5006/", "api/system-logger", httpClient)
        { 
            _applicationName = hostEnvironment.ApplicationName; 
        }

        public SystemLoggerClient(IHostEnvironment hostEnvironment) : this(hostEnvironment, null!) { }

        public async Task<Response<LogResponseDTO>> Log(LogRequestDTO Payload)
        {
            Payload.Timestamp = DateTime.UtcNow;
            Payload.ApplicationName = _applicationName;

            return await GetPostResponse<LogResponseDTO>("log", Payload);
        }

        public void LogError(Exception exception)
        {            
             LogError(exception.Message, exception.StackTrace);
        } 

        public void LogError(string message, string? details = null)
        {
            var payload = new LogRequestDTO
            {
                Type =  LogType.ERROR,
                Message = message,
                Details = details
            };

            _ = Task.Run(() => Log(payload));
        }

        public void LogAlert(Exception exception)
        {
            LogAlert(exception.Message, exception.StackTrace);
        }
         

        public void LogAlert(string message, string? details = null)
        {
            var payload = new LogRequestDTO
            {
                Type = LogType.ALERT,
                Message = message,
                Details = details
            };

            _ = Task.Run(() => Log(payload));
        }

        public void LogInfo(string message, string? details = null)
        {
            var payload = new LogRequestDTO
            {
                Type = LogType.INFO,
                Message = message,
                Details = details
            };

            _ = Task.Run(() => Log(payload));
        }

        public void LogRequest(HttpRequest request)
        {
            var message = $"{request.Method} {request.Path}{request.QueryString}";
            var details = $"Host: {request.Host}\nUser-Agent: {request.Headers.UserAgent}\nContent-Type: {request.ContentType}";

            var payload = new LogRequestDTO
            {
                Type = LogType.REQUEST,
                Message = message,
                Details = details
            };

            _ = Task.Run(() => Log(payload));
        }
    }
}
