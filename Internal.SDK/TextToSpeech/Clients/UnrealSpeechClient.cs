using Internal.SDK.AISession;
using Internal.SDK.Base;
using Internal.SDK.Configuration;
using Internal.SDK.SystemLogger;
using Internal.SDK.TextToSpeech.DTOs;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Security.Cryptography;

namespace Internal.SDK.TextToSpeech.Implementations 
{

    public class UnrealSpeechClient : TextToSpeechBaseClient 
    { 
        public UnrealSpeechClient() : base(SdkRegistry.GetConfig<UnrealSpeechClient>().Domain, null, null) { }

        public UnrealSpeechClient(HttpClient? httpClient = null, ISystemLoggerClient? systemLoggerClient = null) : base(SdkRegistry.GetConfig<UnrealSpeechClient>().Domain, httpClient, systemLoggerClient) { }
         
          
    }
} 
 
