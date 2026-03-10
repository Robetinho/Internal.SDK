using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.SDK.CorePractice.DTOs
{
    public class CreateAppoinmentResponseDTO 
    {
        public  required string Identifier { get; init; }

        public string? Title { get; init; }

        public string? Description { get; init; }

        public string? Note { get; init; }

        public DateTime Start { get; init; }

        public DateTime End { get; init; }

        public ServiceSummaryDTO? EventClass { get; init; }

        public int? AppointmentType { get; init; }

        public int? Attendance { get; init; }

        public int? Source { get; init; }

        public bool EnableNotification { get; init; }

        public bool EnableReminder { get; init; }

        public int? Sequence { get; init; }

        public int? NotificationCount { get; init; }

        public DateTime? LastNotificationDateUtc { get; init; }

        public int? ReminderCount { get; init; }

        public DateTime? LastReminderDateUtc { get; init; }

        public DateTime? ArrivedTime { get; init; }

        public DateTime? WorkBeginTime { get; init; }

        public DateTime? WorkEndTime { get; init; }

        public DateTime? ConfirmDate { get; init; }

        public DateTime? CancelDate { get; init; }

        public string? TimezoneKey { get; init; }

        public bool HasPrepayment { get; init; }

        public PatientDto? Patient { get; init; }  

        public LocationSummaryDTO? Location { get; init; }

        public ProviderDTO? Provider { get; init; }  

        public CalendarSummaryDTO? Calendar { get; init; }

        public object? OnlineAppointment { get; init; }  // null for now

        public List<object>? EventTags { get; init; }  // empty array in example

        public List<object>? Treatments { get; init; } // empty array in example

        public List<MessageDto>? Messages { get; init; }

        public List<object>? Envelopes { get; init; }
         

        public class MessageDto
        {
            public string Identifier { get; init; }

            public string? Body { get; init; }

            public int? Direction { get; init; }

            public int? Status { get; init; }

            public int? Method { get; init; }

            public int? MessageType { get; init; }

            public DateTime? SendDateUtc { get; init; }

            public DateTime? CreateDateUtc { get; init; }

            public string? CreatedFormated { get; init; }
        }
    }
}
