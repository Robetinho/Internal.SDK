using Internal.SDK.__Template.DTOs;
using Internal.SDK.Base;
using Internal.SDK.SlackMessenger;
using Internal.SDK.SystemLogger;

namespace Internal.SDK.__Template
{

    public class CorePracticeClient : ClientBase<__TemplateError>, I__TemplateClient
    {
        public CorePracticeClient(HttpClient? httpClient = null, ISystemLoggerClient? systemLoggerClient = null) : base("http://localhost:5002/", "api/ai-session", httpClient, systemLoggerClient) { }

        //public __TemplateClient() : this(null!) { } 

        public async Task<Response<string, __TemplateError>> GetReply(MessageDto Payload)
        {
            return await GetPostResponse<string>("getReply", Payload);
        } 
    }
}
