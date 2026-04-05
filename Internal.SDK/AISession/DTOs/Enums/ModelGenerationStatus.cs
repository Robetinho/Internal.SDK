using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.SDK.AISession.DTOs.Enums
{
    public enum ModelGenerationStatus
    {        
        Validating_files = 0,
        Running = 1,
        Failed = 2,
        Succeeded = 3,
        Queued = 4,
    } 
}
