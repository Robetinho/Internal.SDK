 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.SDK.CorePractice.DTOs
{
    public class ProviderDTO : ProviderSummaryDTO
    {

        public string? PayeeProviderNumber { get; init; }

        public string? ReportCode { get; init; }

        public string? Description { get; init; }

        public string? MerchantId { get; init; }

        public string? TaxFileNumber { get; init; }

        public string? GstNumber { get; init; }

        public string? JobCode { get; init; }

        public string? IncomeReportCode { get; init; }

        public string? ExpenseReportCode { get; init; }


        public string? LetterHead { get; init; }

        public string? JobTitle { get; init; }

    }
}

