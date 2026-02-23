using Internal.SDK.AISession.DTOs;
using Internal.SDK.Base;
using Internal.SDK.SystemLogger;

namespace Internal.SDK.AISession
{

    public class AISessionClient : ClientBase, IAISessionClient
    {
        public AISessionClient(HttpClient? httpClient = null, ISystemLoggerClient? systemLoggerClient = null) : base("http://localhost:5002/", "api/ai-session", httpClient, systemLogger) { }

        //public AISessionClient() : this(null!) { } 

        public async Task<Response<string>> GetReply(MessageDto Payload)
        {
            return await GetPostResponse<string>("getReply", Payload);
        }
        public async Task<Response<MessageDto>> InitiateSession(InitiateSessionRequestDTO Payload)
        {
            return await GetPostResponse<MessageDto>("initiateSession", Payload);
        }
    }
}
