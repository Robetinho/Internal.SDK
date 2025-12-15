using Internal.SDK.SystemLogger.DTOs;
using Internal.SDK.Base;
using Microsoft.AspNetCore.Http;

namespace Internal.SDK.SystemLogger
{
    public interface ISystemLoggerClient
    {
       // Task<Response<LogResponseDTO>> Log(LogRequestDTO Payload);
        void LogError(Exception exception);
        void LogError(string message, string? details = null);
        void LogAlert(Exception exception);
        void LogAlert(string message, string? details = null);
        void LogInfo(string message, string? details = null); 
        void LogRequest(HttpRequest request);
    }
}