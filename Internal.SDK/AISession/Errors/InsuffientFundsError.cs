using Internal.SDK.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.SDK.AISession
{
    public class InvalidModelError : AISessionError
    {
        public InvalidModelError(string modelName) : base($"The model {modelName} does not exist")
        { 
            ModelName = modelName;
        }
        
        public string ModelName { get; init; }

    }
}
