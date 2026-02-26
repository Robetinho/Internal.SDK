using Internal.SDK.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.SDK.SlackMessenger
{
    public class SlackMessengerException : ServiceException
    {
        internal SlackMessengerException(SlackMessengerError errorDetails): base(errorDetails)
        {

        }
    }
}
