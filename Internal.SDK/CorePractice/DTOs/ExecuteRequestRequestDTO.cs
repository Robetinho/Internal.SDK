
using Internal.SDK.CorePractice.DTOs.Enums;

namespace Internal.SDK.CorePractice.DTOs
{
    public class ExecuteRequestRequestDTO : CorePracticeCachableServiceRequestDTO
    {  
        public required HttpMethod HttpMethod { get; init; }

        public string? Body { get; init; }

        public required string Path { get; init; }

        public Dictionary<string, string>? QueryStringValues { get; init; } 

    }
}
