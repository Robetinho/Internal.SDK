using Internal.SDK.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.SDK.SlackMessenger
{
    public class SlackMessengerError : ServiceError
    {
        internal SlackMessengerError() { }
         
        internal override ServiceError FromException(Exception ex)
        {
            return new SlackMessengerError
            {
                Message = ex.Message
            };
        } 

        public SlackMessengerError(string message)
        {
            base.Message = message;
        } 
    }
}
