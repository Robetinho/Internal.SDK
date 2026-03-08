using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.SDK.CorePractice.DTOs
{
    public class PatientDto
    {
        public string Identifier { get; init; }

        public string? PatientNo { get; init; }

        public string? Firstname { get; init; }

        public string? Lastname { get; init; }

        public string? Middlename { get; init; }

        public string? PreferredName { get; init; }

        public DateTime? DateOfBirth { get; init; }

        public string? Title { get; init; }

        public string? Sex { get; init; }

        public string? Email { get; init; }

        public string? HomePhone { get; init; }

        public string? Mobile { get; init; }

        public string? WorkPhone { get; init; }

        public string? Fax { get; init; }

        public string? Occupation { get; init; }

        public string? CompanyName { get; init; }

        public DateTime? JoinDate { get; init; }

        public string? Description { get; init; }

        public string? MedicareNo { get; init; }

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

        public List<string>? Messages { get; init; }

        public PatientLoginDto? PatientLogin { get; init; }

        public string? FamilyRole { get; init; }

        public string? ReferralNotes { get; init; }

        public bool? ReceiveMarketing { get; init; }

        public bool? ReceiveRecall { get; init; }

        public bool? IsApproved { get; init; }

        public bool? IsActive { get; init; }

        public bool? IsDeleted { get; init; }

        public bool? AllowLogin { get; init; }

        public string? ReferralSource { get; init; }

        public string? FeeLevel { get; init; }

        public string? CurrentHistory { get; init; }

        public string? DefaultInsurance { get; init; }

        public string? ProfileMedia { get; init; }

        public string? CategoryLabel { get; init; }

        public DateTime? MedicalFormSubmitDateUtc { get; init; }

        public DateTime? MedicalFormCompleteDateUtc { get; init; }

        public DateTime? MessageResponseDateUtc { get; init; }

        public DateTime? MessageReadDateUtc { get; init; }

        public bool? HasNewMessages { get; init; }

        public class PatientLoginDto
        {
            public string? UserName { get; init; }

            public DateTime? LastLoginDateUtc { get; init; }
        }
    }
}
