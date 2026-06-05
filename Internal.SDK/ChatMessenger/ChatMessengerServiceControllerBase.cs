using Internal.SDK.ChatMessenger.DTOs;
using Microsoft.AspNetCore.Mvc;
using Internal.SDK.Base;
using ControllerBase = Internal.SDK.Base.ControllerBase;
using Internal.SDK.SystemLogger;

namespace Internal.SDK.ChatMessenger
{
    [ApiController]
    [Route("api/chat-messenger-service")]
    public abstract class ChatMessengerServiceControllerBase : ControllerBase
    {
        public ChatMessengerServiceControllerBase(ISystemLoggerClient? systemLoggerClient = null) : base(systemLoggerClient) { }

        [Route("getConversation")]
        [HttpPost]
        public async Task<IActionResult> GetConversationRoute([FromBody] ConversationIdentifierDTO Payload)
        {
            return await ExecuteSafeAsync(() => GetConversation(Payload));
        }

        public abstract Task<ConversationDTO> GetConversation(ConversationIdentifierDTO Payload);

        [Route("pushMessages")]
        [HttpPost]
        public async Task<IActionResult> PushMessagesRoute([FromBody] PushMessagesRequestDTO Payload)
        {
            return await ExecuteSafeAsync(() => PushMessages(Payload));
        }

        public abstract Task<bool> PushMessages(PushMessagesRequestDTO Payload);

        [Route("addClient")]
        [HttpPost]
        public async Task<IActionResult> AddClientRoute([FromBody] ClientDTO Payload)
        {
            return await ExecuteSafeAsync(() => AddClient(Payload));
        }

        public abstract Task<bool> AddClient(ClientDTO Payload);

        [Route("updateClient")]
        [HttpPost]
        public async Task<IActionResult> UpdateClientRoute([FromBody] ClientDTO Payload)
        {
            return await ExecuteSafeAsync(() => UpdateClient(Payload));
        }

        public abstract Task<bool> UpdateClient(ClientDTO Payload);

        [Route("deleteClient")]
        [HttpPost]
        public async Task<IActionResult> DeleteClientRoute([FromBody] string Payload)
        {
            return await ExecuteSafeAsync(() => DeleteClient(Payload));
        }

        public abstract Task<bool> DeleteClient(string Payload);

        [Route("getClientById")]
        [HttpPost]
        public async Task<IActionResult> GetClientByIdRoute([FromBody] string Payload)
        {
            return await ExecuteSafeAsync(() => GetClientByIdClient(Payload));
        }

        public abstract Task<ClientDTO> GetClientByIdClient(string Payload);

    }
}
