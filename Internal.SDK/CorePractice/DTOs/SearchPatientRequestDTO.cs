using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.SDK.CorePractice.DTOs
{
    public class SearchPatientRequestDTO : CorePracticeCachableServiceRequestDTO
    { 
        public string? CardNo { get; init; }

        public string? Firstname { get; init; }

        public string? Lastname { get; init; }

        public string? Mobile { get; init; }

        public string? Email { get; init; }

        public string? HomePhone { get; init; }

        public string? InvoiceNo { get; init; }
    }
}
