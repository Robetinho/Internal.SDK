using Internal.SDK.ChatMessenger.DTOs;
using Internal.SDK.Base;

namespace Internal.SDK.ChatMessenger
{
    public interface IChatMessengerServiceClient
    {
        Task<Response<ConversationDTO, ChatMessengerError>> GetConversation(ConversationIdentifierDTO Payload);

        Task<Response<bool, ChatMessengerError>> PushMessages(PushMessagesRequestDTO Payload);
    }
}