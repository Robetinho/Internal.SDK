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

    public class GoogleTextToSpeechClient : TextToSpeechBaseClient 
    { 
        public GoogleTextToSpeechClient() : base(SdkRegistry.GetConfig<GoogleTextToSpeechClient>().Domain, null, null) { }

        public GoogleTextToSpeechClient(HttpClient? httpClient = null, ISystemLoggerClient? systemLoggerClient = null) : base(SdkRegistry.GetConfig<GoogleTextToSpeechClient>().Domain, httpClient, systemLoggerClient) { }
         
          
    }
} 
 
