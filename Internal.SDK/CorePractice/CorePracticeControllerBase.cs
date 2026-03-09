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
        public async Task<IActionResult> ListLocationsRoute([FromBody] CorePracticeCachableServiceRequestDTO Payload)
        {
            return await ExecuteSafeAsync(() => ListLocations(Payload));
        }

        public abstract Task<ListLocationsResponseDTO[]> ListLocations(CorePracticeCachableServiceRequestDTO Payload);

        [Route("listAppointmentTypes")]
        [HttpPost]
        public async Task<IActionResult> ListAppointmentTypesRoute([FromBody] CorePracticeCachableServiceRequestDTO Payload)
        {
            return await ExecuteSafeAsync(() => ListAppointmentTypes(Payload));
        }

        public abstract Task<ServiceDTO[]> ListAppointmentTypes(CorePracticeCachableServiceRequestDTO Payload);

        [Route("listProviders")]
        [HttpPost]
        public async Task<IActionResult> ListProvidersRoute([FromBody] ListProvidersRequestDTO Payload)
        {
            return await ExecuteSafeAsync(() => ListProviders(Payload));
        }

        public abstract Task<ProviderDTO[]> ListProviders(ListProvidersRequestDTO Payload);

        [Route("searchPatient")]
        [HttpPost]
        public async Task<IActionResult> SearchPatientRoute([FromBody] SearchPatientRequestDTO Payload)
        {
            return await ExecuteSafeAsync(() => SearchPatient(Payload));
        }

        public abstract Task<PatientDto[]> SearchPatient(SearchPatientRequestDTO Payload);

        [Route("createPatient")]
        [HttpPost]
        public async Task<IActionResult> CreatePatientRoute([FromBody] CreatePatientRequestDTO Payload)
        {
            return await ExecuteSafeAsync(() => CreatePatient(Payload));
        }

        public abstract Task<PatientDto> CreatePatient(CreatePatientRequestDTO Payload);


        [Route("listLocationAvailabilitySlots")]
        [HttpPost]
        public async Task<IActionResult> ListLocationAvailabilitySlotsRoute([FromBody] ListLocationAvailabilitySlotsRequestDTO Payload)
        {
            return await ExecuteSafeAsync(() => ListLocationAvailabilitySlots(Payload));
        }

        public abstract Task<PatientDto> ListLocationAvailabilitySlots(ListLocationAvailabilitySlotsRequestDTO Payload);

        [Route("listLocationAvailabilities")]
        [HttpPost]
        public async Task<IActionResult> ListLocationAvailabilitiesRoute([FromBody] ListLocationAvailabilitiesRequestDTO Payload)
        {
            return await ExecuteSafeAsync(() => ListLocationAvailabilities(Payload));
        }

        public abstract Task<ListLocationAvailabilitySlotsResponseDTO> ListLocationAvailabilities(ListLocationAvailabilitiesRequestDTO Payload);
    }

}
