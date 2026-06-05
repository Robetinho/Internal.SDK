
using Internal.SDK.ChatMessenger.DTOs.Enums;
using Internal.SDK.Configuration;

namespace Internal.SDK.ChatMessenger.DTOs
{
    public class ClientDTO
    {
        public required string ClientId { get; set; }

        public required string ClientName { get; set; }
        
        public required Service Service { get; set; }

        public required int SettingsId { get; set; }

        public bool? ShowTyping { get; set; }

        public required bool ShowConnecting { get; set; }

        public required bool AutoReply { get; set; }

        public required int MaxUnrepliedMessages { get; set; }

        public required string MessageHeaderText { get; set; }

        public required string MessageSubHeaderText { get; set; }

        public required string MessageIconUrl { get; set; }

        public required string PanelHeaderText { get; set; }

        public required string PanelBackgroundColor { get; set; }

        public required string HeaderBackgroundColor { get; set; }

        public required string HeaderBackgroundFontColor { get; set; }

        public required int PanelBorderRadius { get; set; }

        public required string UserMessageColor { get; set; }

        public required string UserMessageFontColor { get; set; }

        public required int UserMessageRadius { get; set; }

        public required int UserMessageLateralPadding { get; set; }

        public required int UserMessageLongitudinalPadding { get; set; }

        public required string UserMessageFontFamily { get; set; }

        public required int UserMessageFontWeight { get; set; }

        public required int UserMessageFontSize { get; set; }

        public required string SystemMessageColor { get; set; }

        public required string SystemMessageFontColor { get; set; }

        public required int SystemMessageRadius { get; set; }

        public required int SystemMessageLateralPadding { get; set; }

        public required int SystemMessageLongitudinalPadding { get; set; }

        public required string SystemMessageFontFamily { get; set; }

        public required int SystemMessageFontWeight { get; set; }

        public required int SystemMessageFontSize { get; set; }

        public  List<string> StarupMessages { get; set; } = new();         
    }
}
