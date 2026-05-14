
using Internal.SDK.ChatMessenger.DTOs.Enums;

namespace Internal.SDK.ChatMessenger.DTOs
{
    public class PushMessagesRequestDTO
    {
        public required ConversationIdentifierDTO ConversationIdentifierDTO { get; set; }

        public List<ChatMessageDTO> Messages { get; } = new();
    }
}
