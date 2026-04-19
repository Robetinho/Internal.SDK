using Internal.SDK.__Template.DTOs;
using Internal.SDK.Base;
using Internal.SDK.SlackMessenger;
using Internal.SDK.SystemLogger;

namespace Internal.SDK.__Template
{

    public class __TemplateClientBase : ClientBase<__TemplateError>, I__TemplateClient
    {
        public __TemplateClientBase(string domain, HttpClient? httpClient = null, ISystemLoggerClient? systemLoggerClient = null) : base(domain, "api/ai-session", httpClient, systemLoggerClient) { }

        public async Task<Response<string, __TemplateError>> GetReply(MessageDto Payload)
        {
            return await GetPostResponse<string>("getReply", Payload);
        } 
    }
}
