using Internal.SDK.__Template.DTOs;
using Internal.SDK.Base;
using Internal.SDK.Configuration;
using Internal.SDK.SlackMessenger;
using Internal.SDK.SystemLogger;
using Internal.SDK.TextToSpeech.Implementations;

namespace Internal.SDK.__Template
{

    public class __TemplateClientBaseClient :   __TemplateClientBase
    {

        public __TemplateClientBaseClient() : base(SdkRegistry.GetConfig<__TemplateClientBaseClient>().Domain, null, null) { }

        public __TemplateClientBaseClient(HttpClient? httpClient = null, ISystemLoggerClient? systemLoggerClient = null) : base(SdkRegistry.GetConfig<__TemplateClientBaseClient>().Domain, httpClient, systemLoggerClient) { }

    }
}
