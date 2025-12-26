using Internal.SDK.AISession.DTOs.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.SDK.AISession.DTOs
{
    public class InitiateSessionRequestDTO
    {

        public required ModelType ModelType { get; init; } = ModelType.GPT_4_1;

        public Guid? SessionId { get; init; }

        public required string Prompt { get; init; }

        public List<MessageDto>? MessageHistory { get; init; }
    }
}
