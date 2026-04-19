using Internal.SDK.Base;
using Internal.SDK.Configuration;
using Internal.SDK.CorePractice.DTOs;
using Internal.SDK.SlackMessenger;
using Internal.SDK.SystemLogger; 

namespace Internal.SDK.CorePractice.Clients
{

    public class CorePracticeClient : CorePracticeBaseClient
    {

        public CorePracticeClient() : base(SdkRegistry.GetConfig<CorePracticeClient>().Domain, null, null) { }

        public CorePracticeClient(HttpClient? httpClient = null, ISystemLoggerClient? systemLoggerClient = null) : base(SdkRegistry.GetConfig<CorePracticeClient>().Domain, httpClient, systemLoggerClient) { }
    }
}
