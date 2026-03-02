
using Internal.SDK.CorePractice.DTOs.Enums;

namespace Internal.SDK.CorePractice.DTOs
{
    public class ExecuteRequestRequestDTO
    {
        public CacheRegime CacheRegime { get; init; } = CacheRegime.IgnoreCache;      
        
        public int CachePeriodSeconds { get; init; } = 86400; // Default to 24 hours

        public required HttpMethod HttpMethod { get; init; }

        public string? Body { get; init; }

        public required string Path { get; init; }

        public Dictionary<string, string>? QueryStringValues { get; init; }

        public required Guid ClientId { get; init; }

    }
}
