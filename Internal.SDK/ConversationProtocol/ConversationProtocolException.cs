using Internal.SDK.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.SDK.ConversationProtocol
{
    public class ConversationProtocolException : ServiceException
    {
        internal ConversationProtocolException(ConversationProtocolError errorDetails): base(errorDetails)
        {

        }
    }
}
