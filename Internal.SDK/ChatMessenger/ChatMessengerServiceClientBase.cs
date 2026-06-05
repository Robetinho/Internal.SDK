using Internal.SDK.ChatMessenger.DTOs;
using Internal.SDK.Base;
using Internal.SDK.SlackMessenger;
using Internal.SDK.SystemLogger;

namespace Internal.SDK.ChatMessenger
{

    public class ChatMessengerServiceClientBase : ClientBase<ChatMessengerError>, IChatMessengerServiceClient
    {
        public ChatMessengerServiceClientBase(string domain, HttpClient? httpClient = null, ISystemLoggerClient? systemLoggerClient = null) 
            : base(domain, "api/chat-messenger-service", httpClient, systemLoggerClient) { }

        public async Task<Response<ConversationDTO, ChatMessengerError>> GetConversation(ConversationIdentifierDTO Payload)
        {
            return await GetPostResponse<ConversationDTO>("getConversation", Payload);
        }

        public async Task<Response<bool, ChatMessengerError>> PushMessages(PushMessagesRequestDTO Payload)
        {
            return await GetPostResponse<bool>("pushMessages", Payload);
        }

        public async Task<Response<bool, ChatMessengerError>> AddClient(ClientDTO Payload)
        {
            return await GetPostResponse<bool>("addClient", Payload);
        }

        public async Task<Response<bool, ChatMessengerError>> UpdateClient(ClientDTO Payload)
        {
            return await GetPostResponse<bool>("updateClient", Payload);
        }

        public async Task<Response<ClientDTO, ChatMessengerError>> GetClientByClientId(string Payload)
        {
            return await GetPostResponse<ClientDTO>("getClientByClientId", Payload);
        }

        public async Task<Response<bool, ChatMessengerError>> DeleteClient(string Payload)
        {
            return await GetPostResponse<bool>("deleteClient", Payload);
        }

    }
}
