using Internal.SDK.AISession.DTOs; 
using Microsoft.AspNetCore.Mvc;
using Internal.SDK.Base;
using ControllerBase = Internal.SDK.Base.ControllerBase;

namespace Internal.SDK.AISession
{
    [ApiController]
    [Route("api/ai-session")] 
    public abstract class AISessionControllerBase :  ControllerBase
    {
        [Route("getReply")]
        [HttpPost]
        public async Task<IActionResult> GetReplyRoute([FromBody] MessageDto payload)
        {
            return await  ExecuteSafeAsync(() => GetReply(payload));
        }

        public abstract Task<string> GetReply(MessageDto payload);

        [Route("initiateSession")]
        [HttpPost]
        public async Task<IActionResult> InitiateSessionRoute([FromBody] InitiateSessionRequestDTO payload)
        {
            return await ExecuteSafeAsync(() => InitiateSession(payload));
        }

        public abstract Task<MessageDto> InitiateSession(InitiateSessionRequestDTO payload);
    } 
   
}
