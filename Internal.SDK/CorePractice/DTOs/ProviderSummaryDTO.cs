using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.SDK.CorePractice.DTOs
{
    public class ProviderSummaryDTO
    {
        public required string Identifier { get; init; }

        public required string ProviderName { get; init; }

        public string? Title { get; init; }

        public string? Firstname { get; init; }

        public string? ProviderNumber { get; init; }

        public string? Status { get; init; }

        public bool? IsDeleted { get; init; }

    }
}