using Internal.SDK.Base;
using Internal.SDK.ConversationProtocol;
using Internal.SDK.SlackMessenger.DTOs;
using Internal.SDK.SystemLogger;
using Microsoft.AspNetCore.Mvc;
using ControllerBase = Internal.SDK.Base.ControllerBase;

namespace Internal.SDK.SlackMessenger
{
    [ApiController]
    [Route("api/slack-messenger")]
    public abstract class SlackMessengerControllerBase : ControllerBase
    {
        public SlackMessengerControllerBase(ISystemLoggerClient? systemLoggerClient = null) : base(systemLoggerClient) { }

        [Route("sendSlackMessage")]
        [HttpPost]
        public async Task<IActionResult> SendSlackMessageRoute([FromBody] SendSlackMessageRequestDTO Payload)
        {
            return await ExecuteSafeAsync(() => SendSlackMessage(Payload));
        }

        public abstract Task<SendSlackMessageResponseDTO> SendSlackMessage(SendSlackMessageRequestDTO Payload);

    }
}
