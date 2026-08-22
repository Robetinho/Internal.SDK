using Internal.SDK.Email.DTOs;
using Microsoft.AspNetCore.Mvc;
using Internal.SDK.Base;
using ControllerBase = Internal.SDK.Base.ControllerBase;
using Internal.SDK.SystemLogger;

namespace Internal.SDK.Email
{
    [ApiController]
    [Route("api/email")]
    public abstract class EmailControllerBase : ControllerBase
    {
        public EmailControllerBase(ISystemLoggerClient? systemLoggerClient = null) : base(systemLoggerClient) { }

        [Route("sendEmail")]
        [HttpPost]
        public async Task<IActionResult> SendEmailRoute([FromBody] EmailDto Payload)
        {
            return await ExecuteSafeAsync(() => SendEmail(Payload));
        }

        public abstract Task<bool> SendEmail(EmailDto Payload);


    }

}
