using Internal.SDK.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.SDK.SystemLogger
{
    public class SystemLoggerError : ServiceError
    {
        internal SystemLoggerError() { }
         
        internal override ServiceError FromException(Exception ex)
        {
            return new SystemLoggerError
            {
                Message = ex.Message
            };
        } 

        public SystemLoggerError(string message)
        {
            base.Message = message;
        } 
    }
}
