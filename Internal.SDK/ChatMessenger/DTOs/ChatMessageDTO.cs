
using Internal.SDK.ChatMessenger.DTOs.Enums;

namespace Internal.SDK.ChatMessenger.DTOs
{
    public class ChatMessageDTO
    {
        public required MessageType Type { get; set; }

        public required string Message { get; set; }
    }
}
