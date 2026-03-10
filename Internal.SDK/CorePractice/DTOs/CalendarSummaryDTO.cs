using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.SDK.CorePractice.DTOs
{
    public class CalendarSummaryDTO
    {

        public required string Identifier { get; init; }

        public string? Description { get; init; }

        public string? DisplayName { get; init; }

        public bool? IsActive { get; init; }

        public int? TimeCancel { get; init; }

        public string? ProfileUrl { get; init; }

        public int? Order { get; init; }
    }
}
