using Internal.SDK.CorePractice.DTOs; 
using Microsoft.AspNetCore.Mvc;
using Internal.SDK.Base;
using ControllerBase = Internal.SDK.Base.ControllerBase;

namespace Internal.SDK.CorePractice
{
    [ApiController]
    [Route("api/core-practice")] 
    public abstract class CorePracticeControllerBase :  ControllerBase
    {
         
        [Route("deleteClient")]
        [HttpPost]
        public async Task<IActionResult> DeleteClientRoute([FromBody] Guid Payload)
        {
            return await ExecuteSafeAsync<bool, CorePracticeException>(() => DeleteClient(Payload));
        }

        public abstract Task<bool> DeleteClient(Guid Payload);


        [Route("getClient")]
        [HttpPost]
        public async Task<IActionResult> GetClientRoute([FromBody] Guid Payload)
        {
            return await ExecuteSafeAsync<ClientDTO, CorePracticeException>(() => GetClient(Payload));
        }

        public abstract Task<ClientDTO> GetClient(Guid Payload);

        [Route("insertClient")]
        [HttpPost]
        public async Task<IActionResult> InsertClientRoute([FromBody] ClientDTO Payload)
        {
            return await ExecuteSafeAsync<ClientDTO, CorePracticeException>(() => InsertClient(Payload));
        }

        public abstract Task<ClientDTO> InsertClient(ClientDTO Payload);

        [Route("updateClient")]
        [HttpPost]
        public async Task<IActionResult> UpdateClientRoute([FromBody] ClientDTO Payload)
        {
            return await ExecuteSafeAsync<ClientDTO, CorePracticeException>(() => UpdateClient(Payload));
        }

        public abstract Task<ClientDTO> UpdateClient(ClientDTO Payload);
    }

}
