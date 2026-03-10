using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.SDK.CorePractice.DTOs
{
    public class CalendarDTO : CalendarSummaryDTO
    {
         

        public string? CalendarKey { get; init; }
         

        public string? TimezoneKey { get; init; }

        public string? ProfileText { get; init; }

        public string? CalendarPolicy { get; init; }

        public int? OpenDay { get; init; }

        public int? SlotLimit { get; init; }

        public int? TimeAdvance { get; init; }
         

        public bool? IsEmailNotification { get; init; }

        public DateTime? PublishDateUtc { get; init; }

        public bool? EnableReminderSms { get; init; }

        public bool? EnableCreateEmail { get; init; }

        public bool? EnableUpdateEmail { get; init; }

        public bool? EnableCancelEmail { get; init; }

        public bool? EnableCompleteEmail { get; init; }

        public bool? PromptCompleteEmail { get; init; }

        public string? CustomFeedbackUrl { get; init; }

        public bool? EnableSendForm { get; init; }
         
        public int? Type { get; init; }

        public DateTime? StartDateUtc { get; init; }

        public DateTime? EndDateUtc { get; init; }

        public bool? IsOnlineBooking { get; init; }
         

        public bool? IsDeleted { get; init; }

        public string? ProfilePicturePath { get; init; }

        public string? Label { get; init; }

        public string? Reminder1Schedule { get; init; }

        public string? Reminder2Schedule { get; init; }

        public DateTime? LastReminder1RunDateTimeUtc { get; init; }

        public DateTime? LastReminder2RunDateTimeUtc { get; init; }

        public object? Owner { get; init; }

        public List<LocationSummaryDTO>? Locations { get; init; }
         

 

        //public string? Explanation { get; init; }

        //public string? Group { get; init; }

        //public int? Order { get; init; }

        //public int? Type { get; init; }

        //public int? Estimate { get; init; }

        //public string? Mode { get; init; } 

        //public string? ModeValue { get; init; }

        //public bool? RequireApproval { get; init; }

        //public bool? IsInternalBooking { get; init; }

        //public bool? IsOnlineBooking { get; init; }

        //public bool? IsActive { get; init; }

        //public string? EventKey { get; init; }

        //public string? OnlineServiceKey { get; init; }

        //public bool? IsTop { get; init; }

        //public bool? IsFirstReminder { get; init; }

        //public bool? IsSecondReminder { get; init; }

        //public bool? IsResendReminder { get; init; }

        //public DateTime? StartDate { get; init; }

        //public DateTime? EndDate { get; init; }

        //public object? Item { get; init; }

        //public int? OnlinePaymentType { get; init; }

        //public string? DisplayPrice { get; init; }

        //public decimal? Amount { get; init; } 
    }
}
