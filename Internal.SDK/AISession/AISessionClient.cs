using Internal.SDK.AISession.DTOs;
using Internal.SDK.Base;

namespace Internal.SDK.AISession 
{

    public class AISessionClient : ClientBase
    {   
        public AISessionClient(HttpClient httpClient) : base("http://localhost:5002/", "api/ai-session", httpClient) { }
         
        public AISessionClient() : this(null!) { } 
         
        public async Task<Response<string>> GetReply(MessageDto payload)
        {
            return await GetPostResponse<string>("getReply", payload);
        }
        public async Task<Response<MessageDto>> InitiateSession(InitiateSessionRequestDTO payload)
        {
            return await GetPostResponse<MessageDto>("initiateSession", payload);
        }
    }
}
