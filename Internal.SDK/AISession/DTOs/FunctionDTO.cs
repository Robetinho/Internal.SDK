using Internal.SDK.AISession.DTOs.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.SDK.AISession.DTOs
{
    public class FunctionDTO
    {
        public required string Name { get; init; }

        public required string Description { get; init; }

        public required List<FunctionPropertiesDTO> Properties { get; init; }  
    }
}
