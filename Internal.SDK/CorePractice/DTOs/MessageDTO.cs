
using CorePracticeServiceAPI.Entities;
using System.Data;

namespace Internal.SDK.CorePractice.DTOs
{
    public class MessageDto
    {
        public required string Identifier { get; init; }

        public string? Body { get; init; }

        public int? Direction { get; init; }

        public int? Status { get; init; }

        public int? Method { get; init; }

        public int? MessageType { get; init; }

        public DateTime? SendDateUtc { get; init; }

        public DateTime? CreateDateUtc { get; init; }

        public string? CreatedFormated { get; init; }
    }
}
