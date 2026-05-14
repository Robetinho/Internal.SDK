using Internal.SDK.ChatMessenger.DTOs;
using Internal.SDK.Base;
using Internal.SDK.SlackMessenger;
using Internal.SDK.SystemLogger;

namespace Internal.SDK.ChatMessenger
{

    public class ChatMessengerServiceClientBase : ClientBase<ChatMessengerError>, IChatMessengerServiceClient
    {
        public ChatMessengerServiceClientBase(string domain, HttpClient? httpClient = null, ISystemLoggerClient? systemLoggerClient = null) : base(domain, "api/ai-session", httpClient, systemLoggerClient) { }

        public async Task<Response<ConversationDTO, ChatMessengerError>> GetConversation(ConversationIdentifierDTO Payload)
        {
            return await GetPostResponse<ConversationDTO>("getConversation", Payload);
        }

        public async Task<Response<bool, ChatMessengerError>> PushMessages(PushMessagesRequestDTO Payload)
        {
            return await GetPostResponse<bool>("pushMessages", Payload);
        } 
    }
}
