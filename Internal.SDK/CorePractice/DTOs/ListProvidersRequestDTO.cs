using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.SDK.CorePractice.DTOs
{
    public class ListProvidersRequestDTO : CorePracticeCachableServiceRequestDTO
    {  
        public string LocationIdentifier { get; init; }
         
    }
}
