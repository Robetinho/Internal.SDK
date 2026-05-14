using Internal.SDK.ChatMessenger.DTOs;
using Microsoft.AspNetCore.Mvc;
using Internal.SDK.Base;
using ControllerBase = Internal.SDK.Base.ControllerBase;
using Internal.SDK.SystemLogger;

namespace Internal.SDK.ChatMessenger
{
    [ApiController]
    [Route("api/chat-messenger-service")]
    public abstract class ChatMessengerServiceControllerBase : ControllerBase
    {
        public ChatMessengerServiceControllerBase(ISystemLoggerClient? systemLoggerClient = null) : base(systemLoggerClient) { }

        [Route("getConversation")]
        [HttpPost]
        public async Task<IActionResult> GetConversationRoute([FromBody] ConversationIdentifierDTO Payload)
        {
            return await ExecuteSafeAsync(() => GetConversation(Payload));
        }

        public abstract Task<ConversationDTO> GetConversation(ConversationIdentifierDTO Payload);

        [Route("pushMessages")]
        [HttpPost]
        public async Task<IActionResult> PushMessagesRoute([FromBody] PushMessagesRequestDTO Payload)
        {
            return await ExecuteSafeAsync(() => PushMessages(Payload));
        }

        public abstract Task<bool> PushMessages(PushMessagesRequestDTO Payload);
         
    } 
}
