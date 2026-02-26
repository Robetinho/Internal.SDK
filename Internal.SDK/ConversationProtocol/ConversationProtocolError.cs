using Internal.SDK.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.SDK.ConversationProtocol
{
    public class ConversationProtocolError : ServiceError
    {
        internal ConversationProtocolError() { }
         
        internal override ServiceError FromException(Exception ex)
        {
            return new ConversationProtocolError
            {
                Message = ex.Message
            };
        } 

        public ConversationProtocolError(string message)
        {
            base.Message = message;
        } 
    }
}
