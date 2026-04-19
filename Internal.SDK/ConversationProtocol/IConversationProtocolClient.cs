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

    public interface IConversationProtocolClient
    {          
        Task<Response<MessageDto, ConversationProtocolError>> GetReply(MessageDto payload);
        
        Task<Response<MessageDto, ConversationProtocolError>> Initiate(string payload);
    }
}
