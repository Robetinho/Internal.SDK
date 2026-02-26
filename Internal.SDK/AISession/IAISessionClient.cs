using Internal.SDK.AISession.DTOs;
using Internal.SDK.Base;

namespace Internal.SDK.AISession
{
    public interface IAISessionClient
    {
        Task<Response<string, AISessionError>> GetReply(MessageDto Payload);

        Task<Response<MessageDto, AISessionError>> InitiateSession(InitiateSessionRequestDTO Payload);
    }
}