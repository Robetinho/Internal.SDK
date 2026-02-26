using Internal.SDK.Base;
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

    public class ConversationProtocolClient : ClientBase<ConversationProtocolError>
    {  
        public ConversationProtocolClient(HttpClient httpClient, ISystemLoggerClient systemLogger) : base("http://localhost:5000/", "api/conversation-protocol", httpClient, systemLogger) { }

        public async Task<Response<MessageDto, ConversationProtocolError>> GetReply(MessageDto payload)
        {
            return await GetPostResponse<MessageDto>("getReply", payload);
        }
        public async Task<Response<MessageDto, ConversationProtocolError>> Initiate(string payload)
        {
            return await GetPostResponse<MessageDto>("initialise", payload);
        }
    }
}
