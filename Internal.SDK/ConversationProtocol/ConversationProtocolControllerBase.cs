using Internal.SDK.ConversationProtocol.DTOs;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Internal.SDK.Base
{
    [ApiController]
    [Route("api/conversation-protocol")]
    public abstract class ConversationProtocolControllerBase :  ControllerBase
    {
        [Route("getReply")]
        [ HttpPost]
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
