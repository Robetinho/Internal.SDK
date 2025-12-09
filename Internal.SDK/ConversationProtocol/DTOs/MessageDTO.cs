using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.SDK.ConversationProtocol.DTOs
{
    public class MessageDto
    {
        public required string ConversationId { get; set; }

        public required string Message { get; set; }
    }
     
}
