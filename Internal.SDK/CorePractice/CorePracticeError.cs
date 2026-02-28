using Internal.SDK.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.SDK.CorePractice
{
    public class CorePracticeError : ServiceError
    {
        internal CorePracticeError() { }
         
        internal override ServiceError FromException(Exception ex)
        {
            return new CorePracticeError
            {
                Message = ex.Message
            };
        } 

        public CorePracticeError(string message)
        {
            base.Message = message;
        } 
    }
}
