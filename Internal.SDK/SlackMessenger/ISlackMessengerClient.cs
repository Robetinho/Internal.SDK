using Internal.SDK.SlackMessenger.DTOs;
using Internal.SDK.Base;

namespace Internal.SDK.SlackMessenger
{
    public interface ISlackMessengerClient
    {
        Task<Response<SendSlackMessageResponseDTO, SlackMessengerError>> SendSlackMessage(SendSlackMessageRequestDTO Payload);

        Task<bool> SendSlackMessage(string slackChannelName, string message);
    }
}