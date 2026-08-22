using Internal.SDK.Configuration;
using Internal.SDK.SystemLogger;

namespace Internal.SDK.Email
{

    public class EmailClient :   EmailClientBase
    {

        public EmailClient() : base(SdkRegistry.GetConfig<EmailClient>().Domain, null, null) { }

        public EmailClient(HttpClient? httpClient = null, ISystemLoggerClient? systemLoggerClient = null) : base(SdkRegistry.GetConfig<EmailClient>().Domain, httpClient, systemLoggerClient) { }

    }
}
