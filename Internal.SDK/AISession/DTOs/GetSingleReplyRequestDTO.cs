using Internal.SDK.AISession.DTOs.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.SDK.AISession.DTOs
{
    public class GetSingleReplyRequestDTO
    {

        public required ModelTypeDTO ModelType { get; init; } 

        public required string Prompt { get; init; }

        public List<MessageDto>? MessageHistory { get; init; }
    }
}
