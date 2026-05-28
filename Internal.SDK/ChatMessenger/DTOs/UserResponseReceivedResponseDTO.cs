
using Internal.SDK.ChatMessenger.DTOs.Enums;

namespace Internal.SDK.ChatMessenger.DTOs
{
    public class UserResponseReceivedResponseDTO
    { 
        public ConversationSettingsDTO? ConversationSettings { get; set; }

        public List<ChatMessageDTO> Messages { get; set;  } = new();
    }
}
