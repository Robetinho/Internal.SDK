using Internal.SDK.CorePractice.DTOs;
using Internal.SDK.Base;
using Internal.SDK.SlackMessenger;
using Internal.SDK.SystemLogger;

namespace Internal.SDK.CorePractice
{

    public class CorePracticeClient : ClientBase<CorePracticeError>, ICorePracticeClient
    {
        public CorePracticeClient(HttpClient? httpClient = null, ISystemLoggerClient? systemLoggerClient = null) : base("http://localhost:5007/", "api/core-practice", httpClient, systemLoggerClient) { }

        public async Task<Response<bool, CorePracticeError>> DeleteClient(Guid Payload)
        {
            return await GetPostResponse<bool>("deleteClient", Payload);
        }

        public async Task<Response<ClientDTO, CorePracticeError>> GetClient(Guid Payload)
        {
            return await GetPostResponse<ClientDTO>("getClient", Payload);
        }
         
         
        public async Task<Response<ClientDTO, CorePracticeError>> InsertClient(ClientDTO Payload)
        {
            return await GetPostResponse<ClientDTO>("insertClient", Payload);
        }

        public async Task<Response<bool, CorePracticeError>> UpdateClient(ClientDTO Payload)
        {
            return await GetPostResponse<bool>("updateClient", Payload);
        }
    }
}
