using Internal.SDK.SystemLogger.DTOs; 
using Microsoft.AspNetCore.Mvc;
using Internal.SDK.Base;
using ControllerBase = Internal.SDK.Base.ControllerBase;

namespace Internal.SDK.SystemLogger
{
    [ApiController]
    [Route("api/system-logger")] 
    public abstract class SystemLoggerControllerBase :  ControllerBase
    {
        [Route("log")]
        [HttpPost]
        public async Task<IActionResult> LogRoute([FromBody] LogRequestDTO Payload)
        {
            return await  ExecuteSafeAsync<LogResponseDTO, SystemLoggerException>(() => Log(Payload));
        }

        public abstract Task<LogResponseDTO> Log(LogRequestDTO Payload);
         
    }  
}
