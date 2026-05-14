using Internal.SDK.ChatMessenger.DTOs;
using Internal.SDK.Base;
using Internal.SDK.Configuration;
using Internal.SDK.SlackMessenger;
using Internal.SDK.SystemLogger;
using Internal.SDK.TextToSpeech.Implementations;

namespace Internal.SDK.ChatMessenger
{

    public class ChatMessengerServiceClient :   ChatMessengerServiceClientBase
    {

        public ChatMessengerServiceClient() : base(SdkRegistry.GetConfig<ChatMessengerServiceClient>().Domain, null, null) { }

        public ChatMessengerServiceClient(HttpClient? httpClient = null, ISystemLoggerClient? systemLoggerClient = null) : base(SdkRegistry.GetConfig<ChatMessengerServiceClient>().Domain, httpClient, systemLoggerClient) { }

    }
}
