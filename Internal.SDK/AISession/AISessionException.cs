using Internal.SDK.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.SDK.AISession
{
    public class AISessionException : ServiceException
    {
        internal AISessionException(AISessionError errorDetails): base(errorDetails)
        {

        }
    }
}
