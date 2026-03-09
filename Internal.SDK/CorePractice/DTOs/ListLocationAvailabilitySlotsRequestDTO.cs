using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.SDK.CorePractice.DTOs
{
    public class ListLocationAvailabilitySlotsRequestDTO : CorePracticeCachableServiceRequestDTO
    {
        public required DateOnly StartDate { get; init; }
        
        public required DateOnly EndDate { get; init; }

        public required TimeOnly StartTime { get; init; }

        public required TimeOnly EndTime { get; init; }

        public required int Duration { get; init; }
         
        public required int[] DayOfWeek { get; init; }

        public required string LocationIdentifier { get; init; }
    }
}
