 
namespace Internal.SDK.ChatMessenger.DTOs
{
    public class ConversationDTO
    {
        public required ConversationIdentifierDTO ConversationIdentifier { get; set; }

        public required ConversationSettingsDTO ConversationSettings { get; set; }
        
        public ClientDefinedSettingsDTO? ClientDefinedSettings { get; set; } 

        public List<ChatMessageDTO> MessageHistory { get;  set; } = new();
    }
}
