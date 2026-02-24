using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.SDK.Base
{
    public class ServiceException : Exception
    {  
        internal ServiceException(  string message)
            : base(message)
        { 
        }
    }

    public class InsufficientFundsException : ServiceException
    {
        public decimal FundsRemaining { get; }
        public decimal CostOfRequest { get; }

        public InsufficientFundsException(decimal fundsRemaining, decimal costOfRequest)
            : base(  "Insufficient funds")
        {
            FundsRemaining = fundsRemaining;
            CostOfRequest = costOfRequest;
        }
    }
}
