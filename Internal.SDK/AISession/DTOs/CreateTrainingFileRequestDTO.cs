using Internal.SDK.AISession.DTOs.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.SDK.AISession.DTOs
{
    public class CreateTrainingFileRequestDTO
    {        
        public required string Name { get; init; }

        public required string Description { get; init; }

        public List<TrainingFileItemDTO>? TrainingFileItems { get; init; }
    }
}
