using Internal.SDK.__Template.DTOs;
using Internal.SDK.Base;

namespace Internal.SDK.__Template
{
    public interface I__TemplateClient
    {
        Task<Response<string, __TemplateError>> GetReply(MessageDto Payload);
         
    }
}