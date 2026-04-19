using Internal.SDK.AISession.DTOs;
using Internal.SDK.Base;
using Internal.SDK.Configuration;
using Internal.SDK.SlackMessenger;
using Internal.SDK.SystemLogger;
using Internal.SDK.TextToSpeech.Implementations;
using Microsoft.AspNetCore.Mvc;

namespace Internal.SDK.AISession.Clients
{

    public class OpenAISessionClient : AISessionBaseClient
    { 
        public OpenAISessionClient() : base(SdkRegistry.GetConfig<UnrealSpeechClient>().Domain, null, null) { }

        public OpenAISessionClient(HttpClient? httpClient = null, ISystemLoggerClient? systemLoggerClient = null) : base(SdkRegistry.GetConfig<OpenAISessionClient>().Domain, httpClient, systemLoggerClient) { }


    }
}
