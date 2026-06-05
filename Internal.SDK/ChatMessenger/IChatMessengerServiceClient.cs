using Internal.SDK.ChatMessenger.DTOs;
using Internal.SDK.Base;

namespace Internal.SDK.ChatMessenger
{
    public interface IChatMessengerServiceClient
    {
        Task<Response<ConversationDTO, ChatMessengerError>> GetConversation(ConversationIdentifierDTO Payload);

        Task<Response<bool, ChatMessengerError>> PushMessages(PushMessagesRequestDTO Payload);

        Task<Response<bool, ChatMessengerError>> AddClient(ClientDTO Payload);

        Task<Response<bool, ChatMessengerError>> UpdateClient(ClientDTO Payload);

        Task<Response<ClientDTO, ChatMessengerError>> GetClientByClientId(string Payload);

        Task<Response<bool, ChatMessengerError>> DeleteClient(string Payload);
    }
}