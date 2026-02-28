using Internal.SDK.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.SDK.CorePractice
{
    public class ClientNotFound : CorePracticeError
    {
        public ClientNotFound(Guid clientId) : base($"Client with the client Id {clientId} does not exist")
        { 
            ClientId = clientId;
        }
        
        public Guid ClientId { get; init; }

    }
}
