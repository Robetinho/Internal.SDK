using Internal.SDK.Base;
using Internal.SDK.ConversationProtocol.DTOs;
using Internal.SDK.SystemLogger;
using Microsoft.AspNetCore.Mvc;
using ControllerBase = Internal.SDK.Base.ControllerBase;

namespace Internal.SDK.ConversationProtocol
{
    [ApiController]
    [Route("api/conversation-protocol")]
    public abstract class ConversationProtocolControllerBase : ControllerBase
    {
        public ConversationProtocolControllerBase(ISystemLoggerClient? systemLoggerClient = null) : base(systemLoggerClient) { }

        [Route("getReply")]
        [HttpPost]
        public async Task<IActionResult> GetReplyRoute([FromBody] MessageDto payload)
        {
            return await ExecuteSafeAsync(() => GetReply(payload));
        }

        public abstract Task<MessageDto> GetReply(MessageDto payload);

        [Route("initialise")]
        [HttpPost]
        public async Task<IActionResult> InitialiseRoute([FromBody] string payload)
        {
            return await ExecuteSafeAsync(() => Initialise(payload));
        }

        public abstract Task<MessageDto> Initialise(string clientId);
    }

}
