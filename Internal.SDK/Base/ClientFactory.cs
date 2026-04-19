using Internal.SDK.Configuration;
using Internal.SDK.SystemLogger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.SDK.Base
{
    public interface IClientFactory<T>
    {
        T GetClient(Service Service);

    }
     
    public class ClientFactory<TClient> : IClientFactory<TClient>
    {
        private readonly HttpClient? _httpClient;
        private readonly ISystemLoggerClient? _systemLoggerClient;

        public ClientFactory(HttpClient? httpClient = null, ISystemLoggerClient? systemLoggerClient = null)
        {
            _httpClient = httpClient;
            _systemLoggerClient = systemLoggerClient;
        }

        public TClient GetClient(Service Service)
        {
            return SdkRegistry.GetClient<TClient>(Service, _systemLoggerClient, _httpClient);
        }
    }
}
