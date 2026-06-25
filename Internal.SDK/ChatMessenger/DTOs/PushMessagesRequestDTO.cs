
using Internal.SDK.ChatMessenger.DTOs.Enums;

namespace Internal.SDK.ChatMessenger.DTOs
{
    public class PushMessagesRequestDTO
    {
        public required ConversationIdentifierDTO ConversationIdentifier { get; set; }
        
        public ConversationSettingsDTO? ConversationSettings { get; set; }

        public ClientDefinedSettingsDTO? ClientDefinedSettings { get; set; }

        public List<ChatMessageDTO> Messages { get; set;  } = new();
    }
}
