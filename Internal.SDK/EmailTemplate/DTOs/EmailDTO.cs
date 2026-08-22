 
namespace Internal.SDK.Email.DTOs
{
    public class EmailDto
    {         
        public required string FromAddress { get; init; }
        
        public required string FromDisplayName { get; init; }

        public required string ToAddress { get; init; }

        public required string Subject { get; init; }

        public required string Body { get; init; }

        public required bool IsHtml { get; init; }
    }
}
