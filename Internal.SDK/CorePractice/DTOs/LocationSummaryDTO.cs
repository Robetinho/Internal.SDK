using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.SDK.CorePractice.DTOs
{
    public class LocationSummaryDTO
    {
        public required string Identifier { get; init; }

        public string? LocationName { get; init; }

        public string? Description { get; init; }

        public string? IpAddress { get; init; }

    }
}
