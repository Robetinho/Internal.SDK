using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Internal.SDK.Base
{
    public class ServiceException : Exception
    {
        [JsonInclude]
        internal string? ErrorMessage { get; set; }  // JSON name = "ErrorMessage"

        public ServiceException() { }

        public ServiceException(string message)
            : base(message)
        {
            ErrorMessage = message;
        }

        public override string Message => ErrorMessage ?? base.Message;
    }

    public class InsufficientFundsException : ServiceException
    {
        public decimal FundsRemaining { get; internal set; }
        public decimal CostOfRequest { get; internal set; }


        internal InsufficientFundsException() { }

        public InsufficientFundsException(decimal fundsRemaining, decimal costOfRequest)
            : base("Insufficient funds")
        {
            FundsRemaining = fundsRemaining;
            CostOfRequest = costOfRequest;
        }
    }
}
