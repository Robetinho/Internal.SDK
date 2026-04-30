using Internal.SDK.AISession.DTOs.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.SDK.AISession.DTOs
{
    public class FunctionPropertiesDTO
    {
        public required string Name { get; init; }

        public required string Type { get; init; }
        
        public string[]? Enum { get; init; }

        public bool Required { get; init; } = true;
         
    }
}
