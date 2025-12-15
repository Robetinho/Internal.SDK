using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.SDK.SlackMessenger.DTOs
{
    public class SendSlackMessageRequestDTO
    {
        public required string Message { get; init; }

        public required string SlackChannelName { get; init; } 
    }
}
