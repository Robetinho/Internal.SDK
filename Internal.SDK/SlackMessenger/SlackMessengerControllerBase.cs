using Internal.SDK.Base;
using Internal.SDK.ConversationProtocol;
using Internal.SDK.SlackMessenger.DTOs; 
using Microsoft.AspNetCore.Mvc;
using ControllerBase = Internal.SDK.Base.ControllerBase;

namespace Internal.SDK.SlackMessenger
{
    [ApiController]
    [Route("api/slack-messenger")] 
    public abstract class SlackMessengerControllerBase :  ControllerBase
    {
        [Route("sendSlackMessage")]
        [HttpPost]
        public async Task<IActionResult> SendSlackMessageRoute([FromBody] SendSlackMessageRequestDTO Payload)
        {
            return await  ExecuteSafeAsync<SendSlackMessageResponseDTO, SlackMessengerException>(() => SendSlackMessage(Payload));
        }

        public abstract Task<SendSlackMessageResponseDTO> SendSlackMessage(SendSlackMessageRequestDTO Payload);
         
    }  
}
