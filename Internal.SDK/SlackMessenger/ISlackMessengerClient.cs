using Internal.SDK.SlackMessenger.DTOs;
using Internal.SDK.Base;

namespace Internal.SDK.SlackMessenger
{
    public interface ISlackMessengerClient
    {
        Task<Response<SendSlackMessageResponseDTO>> SendSlackMessage(SendSlackMessageRequestDTO Payload);

        Task<bool> SendSlackMessage(string slackChannelName, string message);
    }
}