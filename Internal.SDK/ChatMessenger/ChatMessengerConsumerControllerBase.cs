using Internal.SDK.ChatMessenger.DTOs;
using Microsoft.AspNetCore.Mvc;
using Internal.SDK.Base;
using ControllerBase = Internal.SDK.Base.ControllerBase;
using Internal.SDK.SystemLogger;

namespace Internal.SDK.ChatMessenger
{
    [ApiController]
    [Route("api/chat-messenger-consumer")]
    public abstract class ChatMessengerConsumerControllerBase : ControllerBase
    {
        public ChatMessengerConsumerControllerBase(ISystemLoggerClient? systemLoggerClient = null) : base(systemLoggerClient) { }

        [Route("userResponseReceived")]
        [HttpPost]
        public async Task<IActionResult> UserResponseReceivedRoute([FromBody] ConversationDTO Payload)
        {            
            return await ExecuteSafeAsync(() => UserResponseReceived(Payload));
        }

        public abstract Task<ChatMessageDTO[]?> UserResponseReceived(ConversationDTO Payload);


    }

}
