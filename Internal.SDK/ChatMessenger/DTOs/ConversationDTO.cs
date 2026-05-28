 
namespace Internal.SDK.ChatMessenger.DTOs
{
    public class ConversationDTO
    {
        public required ConversationIdentifierDTO ConversationIdentifier;
         
        public required ConversationSettingsDTO ConversationSettings { get; set; }

        public List<ChatMessageDTO> MessageHistory { get;  set; } = new();
    }
}
