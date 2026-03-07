using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.SDK.CorePractice.DTOs
{
    public class ListAppointmentTypesResponseDTO
    {
        public sealed class ServiceDto
        {
            public required string Identifier { get; init; }

            public required string Description { get; init; } 

            public string? Explanation { get; init; }

            public string? Group { get; init; }

            public required string FontColor { get; init; }

            public required string BackColor { get; init; }

            public int Order { get; init; }

            public int Type { get; init; }

            public int? Estimate { get; init; }

            public string? Mode { get; init; } 

            public string? ModeValue { get; init; }

            public bool RequireApproval { get; init; }

            public bool IsInternalBooking { get; init; }

            public bool IsOnlineBooking { get; init; }

            public bool IsActive { get; init; }

            public string? EventKey { get; init; }

            public string? OnlineServiceKey { get; init; }

            public bool IsTop { get; init; }

            public bool IsFirstReminder { get; init; }

            public bool IsSecondReminder { get; init; }

            public bool IsResendReminder { get; init; }

            public DateTime? StartDate { get; init; }

            public DateTime? EndDate { get; init; }

            public object? Item { get; init; }

            public int OnlinePaymentType { get; init; }

            public string? DisplayPrice { get; init; }

            public decimal? Amount { get; init; }
        }

    }
}
