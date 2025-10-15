using Internal.SDK.AISession.DTOs; 
using Microsoft.AspNetCore.Mvc; 

namespace Internal.SDK.Base
{
    [ApiController]
    [Route("api/ai-session")] 
    public abstract class AISessionControllerBase :  ControllerBase
    {
        [Route("getResponse")]
        [ HttpPost]
        public async Task<IActionResult> GetResponseRoute([FromBody] MessageDto payload)
        {
            return await ExecuteSafeAsync(() => GetResponse(payload));
        }

        public abstract Task<MessageDto> GetResponse(MessageDto payload);

        [Route("initiateSession")]
        [HttpPost]
        public async Task<IActionResult> InitiateSessionRoute([FromBody] InitiateSessionRequestDTO payload)
        {
            return await ExecuteSafeAsync(() => InitiateSession(payload));
        }

        public abstract Task<MessageDto> InitiateSession(InitiateSessionRequestDTO payload);
    } 
   
}
