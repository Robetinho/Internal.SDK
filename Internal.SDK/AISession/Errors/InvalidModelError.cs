using Internal.SDK.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.SDK.AISession
{
    public class InsuffientFundsError : AISessionError
    {
        public InsuffientFundsError(int requestCost, int availableFunds) : base("Insufficient funds available")
        {
            RequestCost = requestCost;
            AvailableFunds = availableFunds;
        }

        public int RequestCost { get; init; }

        public int AvailableFunds { get; init; }

    }
}
