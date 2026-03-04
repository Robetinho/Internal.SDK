
using CorePracticeServiceAPI.Entities;
using System.Data;

namespace Internal.SDK.CorePractice.DTOs
{
    public class ClientDTO
    {
        public required Guid ClientId { get; init; }

        public required string AccessCode { get; init; }

        public required string Name { get; init; }

        public string? Secret { get; init; }

        public string? AccessToken { get; init; }

        public string? RefreshToken { get; init; }

        public DateTime? TokenExpiry { get; init; }

        public string? TenantId { get; init; }

        public ConnectionStatus ConnectionStatus { get; init; }

        public int? RedirectCode { get; init; }
    }
}
