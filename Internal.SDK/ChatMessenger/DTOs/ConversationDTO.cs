 
namespace Internal.SDK.ChatMessenger.DTOs
{
    public class ConversationDTO
    {
        public required ConversationIdentifierDTO ConversationIdentifier;

        public List<ChatMessageDTO> MessageHistory { get;  set; } = new();
    }
}
