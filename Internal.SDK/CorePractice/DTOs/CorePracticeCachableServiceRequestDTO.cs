
using Internal.SDK.CorePractice.DTOs.Enums;

namespace Internal.SDK.CorePractice.DTOs
{
    public  class CorePracticeCachableServiceRequestDTO : CorePracticeServiceRequestDTO
    {
        public CacheRegime CacheRegime { get; init; } = CacheRegime.IgnoreCache;

        public int CachePeriodSeconds { get; init; } = 86400;  
    }
}
