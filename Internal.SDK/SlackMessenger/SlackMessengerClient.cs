using Internal.SDK.Base;
using Internal.SDK.SlackMessenger.DTOs;
using Internal.SDK.SystemLogger.DTOs;

namespace Internal.SDK.SlackMessenger 
{

    public class SlackMessengerClient : ClientBase, ISlackMessengerClient
    {   
        public SlackMessengerClient(HttpClient httpClient) : base("http://localhost:5005/", "api/slack-messenger", httpClient) { }
         
        public SlackMessengerClient() : this(null!) { } 
           
        public async Task<Response<SendSlackMessageResponseDTO>> SendSlackMessage(SendSlackMessageRequestDTO Payload)
        {
            return await GetPostResponse<SendSlackMessageResponseDTO>("sendSlackMessage", Payload);
        }

        public void SendSlackMessage(string slackChannelName, string message)
        {
            _ = Task.Run(() => SendSlackMessage(new SendSlackMessageRequestDTO {  Message = message, SlackChannelName = slackChannelName} ));
        }
    }
}
