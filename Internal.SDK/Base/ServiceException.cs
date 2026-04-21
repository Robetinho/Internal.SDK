using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Internal.SDK.Base
{
    public class ServiceException : Exception
    {

        internal ServiceException(ServiceError details)
            : base(details.Message)
        {
            Error = details;
        }

        internal ServiceError Error { get; init; }  

    }

     
    public class ServiceError
    {
        internal ServiceError() { }

        public string? Message { get; init; }

        public bool LogError { get; init; } = true;

        internal virtual ServiceError FromException(Exception ex)
        {
            return new ServiceError
            {
                Message = ex.Message
            };
        }

        // Conversion operator calls the virtual method
        public static explicit operator ServiceError(Exception ex)
        {
            // Create a temporary instance to call the virtual method
            return new ServiceError().FromException(ex);
        }
    }



    //public class InsufficientFundsError : ServiceError
    //{
    //    public decimal FundsRemaining { get; internal set; }
    //    public decimal CostOfRequest { get; internal set; }


    //    internal InsufficientFundsError() : base("Insufficient funds") { }

    //    public InsufficientFundsError(decimal fundsRemaining, decimal costOfRequest)
    //        : this()
    //    {
    //        FundsRemaining = fundsRemaining;
    //        CostOfRequest = costOfRequest;
    //    }



    //}
}
