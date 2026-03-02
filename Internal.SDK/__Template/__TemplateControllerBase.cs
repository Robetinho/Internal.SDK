using Internal.SDK.__Template.DTOs; 
using Microsoft.AspNetCore.Mvc;
using Internal.SDK.Base;
using ControllerBase = Internal.SDK.Base.ControllerBase;

namespace Internal.SDK.__Template
{
    [ApiController]
    [Route("api/ai-session")] 
    public abstract class __TemplateControllerBase :  ControllerBase
    {
        [Route("getReply")]
        [HttpPost]
        public async Task<IActionResult> GetReplyRoute([FromBody] MessageDto Payload)
        {
            return await  ExecuteSafeAsync(() => GetReply(Payload));
        }

        public abstract Task<string> GetReply(MessageDto Payload);

     
    } 
   
}
