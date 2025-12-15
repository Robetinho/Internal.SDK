using Internal.SDK.SlackMessenger.DTOs;
using Internal.SDK.Base;

namespace Internal.SDK.SlackMessenger
{
    public interface ISlackMessengerClient
    {
        Task<Response<SendSlackMessageResponseDTO>> SendSlackMessage(SendSlackMessageRequestDTO Payload);

        void SendSlackMessage(string slackChannelName, string message);
    }
}