using Internal.SDK.ChatMessenger.DTOs;
using Internal.SDK.Base;
using Internal.SDK.Configuration;
using Internal.SDK.SlackMessenger;
using Internal.SDK.SystemLogger;
using Internal.SDK.TextToSpeech.Implementations;

namespace Internal.SDK.ChatMessenger
{

    public class ChatMessengerConsumerClient : ChatMessengerConsumerClientBase
    {

        public ChatMessengerConsumerClient() : base(SdkRegistry.GetConfig<ChatMessengerConsumerClient>().Domain, null, null) { }

        public ChatMessengerConsumerClient(HttpClient? httpClient = null, ISystemLoggerClient? systemLoggerClient = null) : base(SdkRegistry.GetConfig<ChatMessengerConsumerClient>().Domain, httpClient, systemLoggerClient) { }

    }
}
