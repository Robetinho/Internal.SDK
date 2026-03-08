using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.SDK.CorePractice.DTOs
{
    public class CreatePatientRequestDTO : CorePracticeServiceRequestDTO
    { 
        public string? Firstname { get; init; }

        public string? Lastname { get; init; }

        public string? Email { get; init; }

        public string? HomePhone { get; init; }

        public string? Mobile { get; init; }

        public DateTime? DateOfBirth { get; init; }

        public string? Sex { get; init; }

        public string? Title { get; init; }

        public string? WorkPhone { get; init; }

        public string? Fax { get; init; }

        public string? Occupation { get; init; }

        public string? CompanyName { get; init; }

        public DateTime? JoinDate { get; init; }

        public string? Description { get; init; }

        public string? AddressLine1 { get; init; }

        public string? AddressLine2 { get; init; }

        public string? Suburb { get; init; }

        public string? Postcode { get; init; }

        public string? State { get; init; }

        public string? AddressLine1Ext { get; init; }

        public string? AddressLine2Ext { get; init; }

        public string? SuburbExt { get; init; }

        public string? PostcodeExt { get; init; }

        public string? StateExt { get; init; }

        public string? ContactName { get; init; }

        public string? ContactPhone { get; init; }

        public string? ContactMobile { get; init; }

        public string? ContactRelationship { get; init; } 
    }
}
