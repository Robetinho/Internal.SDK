using Internal.SDK.Base;
using Internal.SDK.Configuration;
using Internal.SDK.ConversationProtocol;
using Internal.SDK.ConversationProtocol.DTOs;
using Internal.SDK.SystemLogger;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace Internal.SDK.ConversationProtocol
{

    public class ConversationProtocolClient : ConversationProtocolBaseClient 
    {  
        public ConversationProtocolClient() : base(SdkRegistry.GetConfig<ConversationProtocolClient>().Domain, null, null) { }

        public ConversationProtocolClient(HttpClient? httpClient = null, ISystemLoggerClient? systemLoggerClient = null) : base(SdkRegistry.GetConfig<ConversationProtocolClient>().Domain,  httpClient, systemLoggerClient) { }

    }
}
