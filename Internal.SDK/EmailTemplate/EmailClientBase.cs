using Internal.SDK.Email.DTOs;
using Internal.SDK.Base;
using Internal.SDK.SlackMessenger;
using Internal.SDK.SystemLogger;

namespace Internal.SDK.Email
{

    public class EmailClientBase : ClientBase<EmailError>, IEmailClient
    {
        public EmailClientBase(string domain, HttpClient? httpClient = null, ISystemLoggerClient? systemLoggerClient = null) : base(domain, "api/email", httpClient, systemLoggerClient) { }

        public async Task<Response<bool, EmailError>> SendEmail(EmailDto Payload)
        {
            return await GetPostResponse<bool>("sendEmail", Payload);
        } 
    }
}
