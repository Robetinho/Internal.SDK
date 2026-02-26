using Internal.SDK.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.SDK.AISession
{
    public class AISessionError : ServiceError
    {
        internal AISessionError() { }
         
        internal override ServiceError FromException(Exception ex)
        {
            return new AISessionError
            {
                Message = ex.Message
            };
        } 

        public AISessionError(string message)
        {
            base.Message = message;
        } 
    }
}
