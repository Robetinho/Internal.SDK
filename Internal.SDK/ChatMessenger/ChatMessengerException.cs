using Internal.SDK.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.SDK.ChatMessenger
{
    public class ChatMessengerException : ServiceException
    {
        public ChatMessengerException(ChatMessengerError errorDetails): base(errorDetails)
        {

        }
    }
}
