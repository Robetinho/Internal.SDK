using Internal.SDK.Base;
using Internal.SDK.Configuration;
using Internal.SDK.ConversationProtocol;
using Internal.SDK.SystemLogger.DTOs;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;

namespace Internal.SDK.SystemLogger
{

    public class SystemLoggerClient : SystemLoggerBaseClient , IServiceClient
    { 
        public SystemLoggerClient() : base(SdkRegistry.GetConfig<SystemLoggerClient>().Domain,  null) { }

        public SystemLoggerClient(HttpClient? httpClient = null, ISystemLoggerClient? systemLoggerClient = null) : base(SdkRegistry.GetConfig<SystemLoggerClient>().Domain, httpClient) { }

        public override void Injector(HttpClient? httpClient, ISystemLoggerClient? systemLoggerClient)
        {
            base.Injector(httpClient, null);
        }

    }
}
