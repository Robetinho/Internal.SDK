using Internal.SDK.AISession.DTOs;
using Internal.SDK.Base;

namespace Internal.SDK.AISession
{
    public interface IAISessionClient
    {
        Task<Response<string>> GetReply(MessageDto payload);

        Task<Response<MessageDto>> InitiateSession(InitiateSessionRequestDTO payload);
    }
}