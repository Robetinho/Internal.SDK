
using Internal.SDK.AISession.DTOs.Enums;

namespace Internal.SDK.AISession.DTOs
{
    public class MessageDto
    { 
        public required MessageType MessageType { get; init; }

        public required string Text { get; init; }
    }
}
