
using Internal.SDK.ChatMessenger.DTOs.Enums;

namespace Internal.SDK.ChatMessenger.DTOs
{
    public class ConversationSettingsDTO
    {
        public bool? ShowTyping { get; set; }
     
        public required bool ShowConnecting { get; set; }
        
        public required bool AutoReply { get; set; }
        
        public required int MaxUnrepliedMessages { get; set; }
    }
}
