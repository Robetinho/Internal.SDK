using Internal.SDK.__Template.DTOs;
using Internal.SDK.Base;
using Internal.SDK.Configuration;
using Internal.SDK.SlackMessenger;
using Internal.SDK.SystemLogger;
using Internal.SDK.TextToSpeech.Implementations;

namespace Internal.SDK.__Template
{

    public class CorePracticeClient :   __TemplateClientBase
    {

        public CorePracticeClient() : base(SdkRegistry.GetConfig<CorePracticeClient>().Domain, null, null) { }

        public CorePracticeClient(HttpClient? httpClient = null, ISystemLoggerClient? systemLoggerClient = null) : base(SdkRegistry.GetConfig<CorePracticeClient>().Domain, httpClient, systemLoggerClient) { }

    }
}
