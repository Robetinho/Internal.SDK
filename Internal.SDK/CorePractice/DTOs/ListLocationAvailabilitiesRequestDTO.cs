using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.SDK.CorePractice.DTOs
{
    public class ListLocationAvailabilitiesRequestDTO : CorePracticeCachableServiceRequestDTO
    {
        public required DateOnly Start { get; init; }
        
        public required DateOnly End { get; init; }

        public required string LocationIdentifier { get; init; }
    }
}
