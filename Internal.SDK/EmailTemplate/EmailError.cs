using Internal.SDK.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.SDK.Email
{
    public class EmailError : ServiceError
    {
        internal EmailError() { }
         
        internal override ServiceError FromException(Exception ex)
        {
            return new EmailError
            {
                Message = ex.Message
            };
        } 

        public EmailError(string message)
        {
            base.Message = message;
        } 
    }
}
