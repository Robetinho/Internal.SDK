using Internal.SDK.ChatMessenger.DTOs;
using Internal.SDK.Base;
using Internal.SDK.SlackMessenger;
using Internal.SDK.SystemLogger;

namespace Internal.SDK.ChatMessenger
{

    public class ChatMessengerConsumerClientBase : ClientBase<ChatMessengerError>, IChatMessengerConsumerClient
    {
        public ChatMessengerConsumerClientBase(string domain, HttpClient? httpClient = null, ISystemLoggerClient? systemLoggerClient = null) 
            : base(domain, "api/chat-messenger-consumer", httpClient, systemLoggerClient) { }

        public async Task<Response<ChatMessageDTO[]?, ChatMessengerError>> UserResponseReceived(ConversationDTO Payload)
        {
            return await GetPostResponse<ChatMessageDTO[]?>("userResponseReceived", Payload);
        } 
    }
}
