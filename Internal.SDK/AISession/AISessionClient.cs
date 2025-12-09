using Internal.SDK.AISession.DTOs;
using Internal.SDK.Base;

namespace Internal.SDK.AISession 
{

    public class AISessionClient : ClientBase
    {   
        public AISessionClient(HttpClient httpClient) : base("http://localhost:5002/", "api/ai-session", httpClient) { }
         
        public AISessionClient() : this(null!) { } 
         
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
