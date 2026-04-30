
using Internal.SDK.AISession.DTOs.Enums;

namespace Internal.SDK.AISession.DTOs
{
    public class MessageResponseDTO
    {  

        public required decimal EstimatedCost { get; init; }

        public required string Text { get; init; }

        public FunctionResponseDTO[]? FunctionResponses { get; init; } 

    }
}
