
using Internal.SDK.AISession;
using Internal.SDK.AISession.Clients;
using Internal.SDK.Base;
using Internal.SDK.ChatMessenger;
using Internal.SDK.ConversationProtocol;
using Internal.SDK.CorePractice;
using Internal.SDK.CorePractice.Clients;
using Internal.SDK.SlackMessenger;
using Internal.SDK.SlackMessenger.Clients;
using Internal.SDK.SystemLogger;
using Internal.SDK.TextToSpeech;
using Internal.SDK.TextToSpeech.Implementations;

namespace Internal.SDK.Configuration
{
    internal class ClientConfig
    {
        public string Domain { get; set; }

        public Service ServiceName { get; set; }

    }


    public enum Service
    {
        ConversationProtocolServiceAPI = 5000,
        OpenAIServiceAPI = 5002,
        UnrealSpeechServiceAPI = 5004,
        SlackMessengerServiceAPI = 5005,
        SystemLoggerServiceAPI = 5006,
        CorePracticeServiceAPI = 5007,
        GoogleTextToSpeechServiceAPI = 5008,
        ChatMessengerServiceAPI = 5009,

    }



    internal class SdkRegistry
    {
        private static void Register()
        {
            if (_registry == null)
            {
                _registry = new Dictionary<Type, (Type InterfaceType, ClientConfig Config)>();

                RegisterClient<IConversationProtocolClient, ConversationProtocolClient>(new ClientConfig { Domain = "http://localhost:5000/", ServiceName = Service.ConversationProtocolServiceAPI });
                RegisterClient<IAISessionClient, OpenAISessionClient>(new ClientConfig { Domain = "http://localhost:5002/", ServiceName = Service.OpenAIServiceAPI });
                RegisterClient<ITextToSpeechClient, UnrealSpeechClient>(new ClientConfig { Domain = "http://localhost:5004/", ServiceName = Service.UnrealSpeechServiceAPI });
                RegisterClient<ISlackMessengerClient, SlackMessengerClient>(new ClientConfig { Domain = "http://localhost:5005/", ServiceName = Service.OpenAIServiceAPI });
                RegisterClient<ISystemLoggerClient, SystemLoggerClient>(new ClientConfig { Domain = "http://localhost:5006/", ServiceName = Service.SystemLoggerServiceAPI });
                RegisterClient<ICorePracticeClient, CorePracticeClient>(new ClientConfig { Domain = "http://localhost:5007/", ServiceName = Service.CorePracticeServiceAPI });
                RegisterClient<ITextToSpeechClient, GoogleTextToSpeechClient>(new ClientConfig { Domain = "http://localhost:5008/", ServiceName = Service.GoogleTextToSpeechServiceAPI });
                RegisterClient<IChatMessengerServiceClient, ChatMessengerServiceClient>(new ClientConfig { Domain = "http://localhost:5008/", ServiceName = Service.ChatMessengerServiceAPI });

            }

        }



        // Key = Service/Interface Type, Value = The Config + Concrete Type
        private static Dictionary<Type, (Type InterfaceType, ClientConfig Config)>? _registry = null;

        // 1. Register: Supports <Implementation, Service> pattern
        internal static void RegisterClient<TInterface, TImplementation>(ClientConfig config)
            where TImplementation : class, TInterface, IServiceClient, new()
        {
            Register();
            _registry![typeof(TImplementation)] = (typeof(TInterface), config);
        }

        // 2. Get Config by Type
        public static ClientConfig GetConfig<TImplementation>()
        {

            Register();
            return _registry.TryGetValue(typeof(TImplementation), out var entry) ? entry.Config : null;
        }

        // 3. New up by Name and Interface
        internal static TInterface GetClient<TInterface>(Service servinceImplementation, ISystemLoggerClient? systemLoggerClient = null , HttpClient? httpClient = null)  
        {

            Register();
            var client = _registry.FirstOrDefault(client => client.Value.InterfaceType == typeof(TInterface) && client.Value.Config.ServiceName == servinceImplementation);
            var instance = (TInterface)Activator.CreateInstance(client.Key);

            if (instance is IServiceClient serviceInfoInstance)
            {
                (instance as IServiceClient).Injector( httpClient, systemLoggerClient);
            }

            return instance;
        }
    }



}
