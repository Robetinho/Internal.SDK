using Internal.SDK.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.SDK.ChatMessenger
{
    public class ChatMessengerError : ServiceError
    {
        internal ChatMessengerError() { }
         
        internal override ServiceError FromException(Exception ex)
        {
            return new ChatMessengerError
            {
                Message = ex.Message
            };
        } 

        public ChatMessengerError(string message)
        {
            base.Message = message;
        } 
    }
}
