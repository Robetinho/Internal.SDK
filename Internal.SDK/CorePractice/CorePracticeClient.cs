using Internal.SDK.CorePractice.DTOs;
using Internal.SDK.Base;
using Internal.SDK.SlackMessenger;
using Internal.SDK.SystemLogger;

namespace Internal.SDK.CorePractice
{

    public class CorePracticeClient : ClientBase<CorePracticeError>, ICorePracticeClient
    {
        public CorePracticeClient(HttpClient? httpClient = null, ISystemLoggerClient? systemLoggerClient = null) : base("http://localhost:5007/", "api/core-practice", httpClient, systemLoggerClient) { }

        public async Task<Response<bool, CorePracticeError>> DeleteClient(Guid Payload)
        {
            return await GetPostResponse<bool>("deleteClient", Payload);
        }

        public async Task<Response<ClientDTO, CorePracticeError>> GetClient(Guid Payload)
        {
            return await GetPostResponse<ClientDTO>("getClient", Payload);
        }
         
         
        public async Task<Response<ClientDTO, CorePracticeError>> InsertClient(ClientDTO Payload)
        {
            return await GetPostResponse<ClientDTO>("insertClient", Payload);
        }

        public async Task<Response<bool, CorePracticeError>> UpdateClient(ClientDTO Payload)
        {
            return await GetPostResponse<bool>("updateClient", Payload);
        }

        public async Task<Response<string, CorePracticeError>> ExecuteRequest(ExecuteRequestRequestDTO Payload)
        {
            return await GetPostResponse<string>("executeRequest", Payload);
        }

        public async Task<Response<ListLocationsResponseDTO[], CorePracticeError>> ListLocations(CorePracticeCachableServiceRequestDTO Payload)
        {
            return await GetPostResponse<ListLocationsResponseDTO[]>("listLocations", Payload);
        }

        public async Task<Response<ServiceDTO[], CorePracticeError>> ListAppointmentTypes(CorePracticeCachableServiceRequestDTO Payload)
        {
            return await GetPostResponse<ServiceDTO[]>("listAppointmentTypes", Payload);
        }

        public async Task<Response<ProviderDTO[], CorePracticeError>> ListProviders(ListProvidersRequestDTO Payload)
        {
            return await GetPostResponse<ProviderDTO[]>("listProviders", Payload);
        }

        public async Task<Response<PatientDto[], CorePracticeError>> SearchPatient(SearchPatientRequestDTO Payload)
        {
            return await GetPostResponse<PatientDto[]>("searchPatient", Payload);
        }

        public async Task<Response<PatientDto, CorePracticeError>> CreatePatient(CreatePatientRequestDTO Payload)
        {
            return await GetPostResponse<PatientDto>("createPatient", Payload);
        }

        public async Task<Response<ListLocationAvailabilitySlotsResponseDTO[], CorePracticeError>> ListLocationAvailabilitySlots(ListLocationAvailabilitySlotsRequestDTO Payload)
        {
            return await GetPostResponse<ListLocationAvailabilitySlotsResponseDTO[]>("listLocationAvailabilitySlots", Payload);
        }


        public async Task<Response<ListLocationAvailabilitiesResponseDTO[], CorePracticeError>> ListLocationAvailabilities(ListLocationAvailabilitiesRequestDTO Payload)
        {
            return await GetPostResponse<ListLocationAvailabilitiesResponseDTO[]>("listLocationAvailabilities", Payload);
        }

    }
}
