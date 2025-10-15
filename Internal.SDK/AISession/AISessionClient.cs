using Internal.SDK.Base;

namespace Internal.SDK.AISession.DTOs
{

    public class AISessionClient : ClientBase
    {
        public AISessionClient(HttpClient? httpClient = null) : base("http://localhost:5221/", "api/ai-session", httpClient) { }

        public async Task<Response<MessageDto>> GetResponse(MessageDto payload)
        {
            return await GetPostResponse<MessageDto>("getResponse", payload);
        }
        public async Task<Response<MessageDto>> InitiateSession(InitiateSessionRequestDTO payload)
        {
            return await GetPostResponse<MessageDto>("initiateSession", payload);
        }
    }
}
