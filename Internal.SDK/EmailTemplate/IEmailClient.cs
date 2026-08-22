using Internal.SDK.Email.DTOs;
using Internal.SDK.Base;

namespace Internal.SDK.Email
{
    public interface IEmailClient
    {
        Task<Response<bool, EmailError>> SendEmail(EmailDto Payload);         
    }
}