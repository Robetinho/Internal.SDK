using Internal.SDK.ChatMessenger.DTOs;
using Internal.SDK.Base;

namespace Internal.SDK.ChatMessenger
{
    public interface IChatMessengerConsumerClient
    {
        Task<Response<UserResponseReceivedResponseDTO?, ChatMessengerError>> UserResponseReceived(ConversationDTO Payload);        
    }
}