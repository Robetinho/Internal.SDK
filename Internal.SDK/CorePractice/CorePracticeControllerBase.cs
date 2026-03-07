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
            return await ExecuteSafeAsync(() => DeleteClient(Payload));
        }

        public abstract Task<bool> DeleteClient(Guid Payload);


        [Route("getClient")]
        [HttpPost]
        public async Task<IActionResult> GetClientRoute([FromBody] Guid Payload)
        {
            return await ExecuteSafeAsync(() => GetClient(Payload));
        }

        public abstract Task<ClientDTO> GetClient(Guid Payload);

        [Route("insertClient")]
        [HttpPost]
        public async Task<IActionResult> InsertClientRoute([FromBody] ClientDTO Payload)
        {
            return await ExecuteSafeAsync(() => InsertClient(Payload));
        }

        public abstract Task<ClientDTO> InsertClient(ClientDTO Payload);

        [Route("updateClient")]
        [HttpPost]
        public async Task<IActionResult> UpdateClientRoute([FromBody] ClientDTO Payload)
        {
            return await ExecuteSafeAsync(() => UpdateClient(Payload));
        }

        public abstract Task<ClientDTO> UpdateClient(ClientDTO Payload);



        [Route("executeRequest")]
        [HttpPost]
        public async Task<IActionResult> ExecuteRequestRoute([FromBody] ExecuteRequestRequestDTO Payload)
        {
            return await ExecuteSafeAsync(() => ExecuteRequest(Payload));
        }

        public abstract Task<string> ExecuteRequest(ExecuteRequestRequestDTO Payload);



        [Route("listLocations")]
        [HttpPost]
        public async Task<IActionResult> ListLocationsRoute([FromBody] CorePracticeServiceGetRequestDTO Payload)
        {
            return await ExecuteSafeAsync(() => ListLocations(Payload));
        }

        public abstract Task<ListLocationsResponseDTO[]> ListLocations(CorePracticeServiceGetRequestDTO Payload);

        [Route("listAppointmentTypes")]
        [HttpPost]
        public async Task<IActionResult> ListAppointmentTypesRoute([FromBody] CorePracticeServiceGetRequestDTO Payload)
        {
            return await ExecuteSafeAsync(() => ListAppointmentTypes(Payload));
        }

        public abstract Task<ListAppointmentTypesResponseDTO[]> ListAppointmentTypes(CorePracticeServiceGetRequestDTO Payload);
    }

}
