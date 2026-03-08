using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.SDK.CorePractice.DTOs
{
    public class ServiceSummaryDTO
    {
        public required string Identifier { get; init; }

        public string? Description { get; init; }

        public string? FontColor { get; init; }

        public string? BackColor { get; init; }

        public int? Order { get; init; }

        public int? OnlinePaymentType { get; init; }
    }
}
