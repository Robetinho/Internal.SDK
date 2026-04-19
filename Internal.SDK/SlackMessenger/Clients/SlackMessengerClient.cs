using Internal.SDK.Base;
using Internal.SDK.Configuration;
using Internal.SDK.SlackMessenger.DTOs;
using Internal.SDK.SystemLogger;
using Internal.SDK.SystemLogger.DTOs;

namespace Internal.SDK.SlackMessenger.Clients
{

    public class SlackMessengerClient : SlackMessengerBaseClient
    {
        public SlackMessengerClient() : base(SdkRegistry.GetConfig<SlackMessengerClient>().Domain, null, null) { }

        public SlackMessengerClient(HttpClient? httpClient = null, ISystemLoggerClient? systemLoggerClient = null) : base(SdkRegistry.GetConfig<SlackMessengerClient>().Domain, httpClient, systemLoggerClient) { }


    }
}
