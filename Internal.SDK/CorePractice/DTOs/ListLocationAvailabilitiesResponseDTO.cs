using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Internal.SDK.CorePractice.DTOs.CreateAppoinmentResponseDTO;

namespace Internal.SDK.CorePractice.DTOs
{
    public class ListLocationAvailabilitiesResponseDTO
    {
        public string? Identifier { get; init; }

        public string? Description { get; init; }

        public DateTime? Start { get; init; }

        public DateTime? End { get; init; }

        public int? DayOfWeek { get; init; }

        public int? Repeat { get; init; }

        public int? Type { get; init; }

        public bool? AlternateWeek { get; init; }

        public LocationSummaryDTO? Location { get; init; }

        public ProviderSummaryDTO? Provider { get; init; }

        public CalendarDTO? Calendar { get; init; }
    }
}
