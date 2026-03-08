using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.SDK.CorePractice.DTOs
{
    public class ListLocationAvailabilitySlotsRequestDTO : CorePracticeCachableServiceRequestDTO
    {
        public required DateTime Start { get; init; }
        
        public required DateTime End { get; init; }

        public required int Duration { get; init; }
         
        public required int[] DayOfWeek { get; init; }

        public required string LocationIdentifier { get; init; }
    }
}
