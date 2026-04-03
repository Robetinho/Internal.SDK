using Internal.SDK.AISession.DTOs.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.SDK.AISession.DTOs
{
    public class FineTunedModelDTO
    {
        public required int FineTunedModelId { get; init; }

        public required string Name { get; init; }

        public required string Description { get; init; }

        public required int TrainingFileId { get; init; }
        
        public string? ModelId { get; init; }        

        public ModelGenerationStatus? Status { get; init; }
         
    }
}
