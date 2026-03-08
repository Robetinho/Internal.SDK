using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.SDK.CorePractice.DTOs
{
    public class CreateAppoinmentRequestDTO : CorePracticeServiceRequestDTO
    {
        public string? Description { get; init; }

        public required DateTime Start { get; init; }

        public required DateTime End { get; init; }

        public required string LocationId { get; init; }

        public required string CalendarId { get; init; }

        public required string ProviderId { get; init; }

        public required string PatientId { get; init; }

        public required string AppointmentTypeId { get; init; }

        public bool? EnableNotification { get; init; }

        public bool? EnableReminder { get; init; }
    }
}
