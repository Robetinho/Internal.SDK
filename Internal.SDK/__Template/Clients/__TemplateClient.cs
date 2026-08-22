using Internal.SDK.__Template.DTOs;
using Internal.SDK.Base;
using Internal.SDK.Configuration;
using Internal.SDK.SlackMessenger;
using Internal.SDK.SystemLogger;
using Internal.SDK.TextToSpeech.Implementations;

namespace Internal.SDK.__Template
{

    public class __TemplateClient :   __TemplateClientBase
    {

        public __TemplateClient() : base(SdkRegistry.GetConfig<__TemplateClient>().Domain, null, null) { }

        public __TemplateClient(HttpClient? httpClient = null, ISystemLoggerClient? systemLoggerClient = null) : base(SdkRegistry.GetConfig<__TemplateClient>().Domain, httpClient, systemLoggerClient) { }

    }
}
