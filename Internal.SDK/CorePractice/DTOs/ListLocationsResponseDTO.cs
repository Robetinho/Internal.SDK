using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.SDK.CorePractice.DTOs
{
    public class ListLocationsResponseDTO
    {
        public string Identifier { get; init; }

        public string LocationName { get; init; }

        public string? DisplayName { get; init; }

        public string? Description { get; init; }

        public string? CompanyName { get; init; }

        public string? Abn { get; init; }

        public string? Email { get; init; }

        public string? MapUrl { get; init; }

        public string? Phone1 { get; init; }

        public string? Phone2 { get; init; }

        public string? Mobile { get; init; }

        public string? Fax { get; init; }

        public string? Latitude { get; init; }

        public string? Longitude { get; init; }

        public bool IsDeleted { get; init; }

        public bool IsOnlineBooking { get; init; }

        public bool IsOnlinePayment { get; init; }

        public string? AddressLine1 { get; init; }

        public string? AddressLine2 { get; init; }

        public string? Suburb { get; init; }

        public string? Postcode { get; init; }

        public string? State { get; init; }

        public string? Country { get; init; }

        public string? LocationKey { get; init; }

        public string? TimezoneKey { get; init; }

        public string? CancellationPolicy { get; init; }

        public string? PaymentPolicy { get; init; }

        public string? OtherPolicy { get; init; }

        public string? DirectionNote { get; init; }

        public string? DisabledMsg { get; init; }

        public string? DisabledTitle { get; init; }

        public string? IpAddress { get; init; }

        public string? NotificationEmail { get; init; }

        public string? LocationSetting { get; init; }

        public string? LogoUrl { get; init; }

        public string? WebAddress { get; init; }

        public string? ReviewUrl { get; init; }

        public bool IsOnlinePaymentEnabled { get; init; }

    }
}
