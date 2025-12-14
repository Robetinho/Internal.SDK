using Internal.SDK.SlackMessenger.DTOs; 
using Microsoft.AspNetCore.Mvc;
using Internal.SDK.Base;
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
            return await  ExecuteSafeAsync(() => SendSlackMessage(Payload));
        }

        public abstract Task<SendSlackMessageResponseDTO> SendSlackMessage(SendSlackMessageRequestDTO Payload);
         
    }  
}
