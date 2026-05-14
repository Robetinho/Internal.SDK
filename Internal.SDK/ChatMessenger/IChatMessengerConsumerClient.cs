using Internal.SDK.ChatMessenger.DTOs;
using Internal.SDK.Base;

namespace Internal.SDK.ChatMessenger
{
    public interface IChatMessengerConsumerClient
    {
        Task<Response<ChatMessageDTO[]?, ChatMessengerError>> UserResponseReceived(ConversationDTO Payload);        
    }
}