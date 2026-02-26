using Internal.SDK.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.SDK.SystemLogger
{
    public class SystemLoggerException : ServiceException
    {
        internal SystemLoggerException(SystemLoggerError errorDetails): base(errorDetails)
        {

        }
    }
}
