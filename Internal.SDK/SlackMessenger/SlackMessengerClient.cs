using Internal.SDK.Base;
using Internal.SDK.SlackMessenger.DTOs;
using Internal.SDK.SystemLogger;
using Internal.SDK.SystemLogger.DTOs;

namespace Internal.SDK.SlackMessenger
{

    public class SlackMessengerClient : ClientBase<SlackMessengerError>, ISlackMessengerClient
    {
        public SlackMessengerClient(HttpClient? httpClient = null, ISystemLoggerClient? systemLoggerClient  = null) : base("http://localhost:5005/", "api/slack-messenger", httpClient, systemLoggerClient) { }

        //public SlackMessengerClient() : this(null!) { }

        public async Task<Response<SendSlackMessageResponseDTO, SlackMessengerError>> SendSlackMessage(SendSlackMessageRequestDTO Payload)
        {
            return await GetPostResponse<SendSlackMessageResponseDTO>("sendSlackMessage", Payload);
        }

        public async Task<bool> SendSlackMessage(string slackChannelName, string message)
        {
            return (await SendSlackMessage(new SendSlackMessageRequestDTO { Message = message, SlackChannelName = slackChannelName })).Item?.Success ?? false;
        }
    }
}
