using Internal.SDK.CorePractice.DTOs;
using Internal.SDK.Base;

namespace Internal.SDK.CorePractice
{
    public interface ICorePracticeClient
    {
        Task<Response<ClientDTO, CorePracticeError>> GetClient(Guid Payload);
        Task<Response<bool, CorePracticeError>> UpdateClient(ClientDTO Payload);
        Task<Response<ClientDTO, CorePracticeError>> InsertClient(ClientDTO Payload);
        Task<Response<bool, CorePracticeError>> DeleteClient(Guid Payload);
        Task<Response<string, CorePracticeError>> ExecuteRequest(ExecuteRequestRequestDTO Payload);
        Task<Response<ListLocationsResponseDTO[], CorePracticeError>> ListLocations(CorePracticeCachableServiceRequestDTO Payload);
        Task<Response<ServiceDTO[], CorePracticeError>> ListAppointmentTypes(CorePracticeCachableServiceRequestDTO Payload);
        Task<Response<ProviderDTO[], CorePracticeError>> ListProviders(ListProvidersRequestDTO Payload);
        Task<Response<PatientDto[], CorePracticeError>> SearchPatient(SearchPatientRequestDTO Payload);
        Task<Response<ListLocationAvailabilitySlotsResponseDTO, CorePracticeError>> ListLocationAvailabilitySlots(ListLocationAvailabilitySlotsRequestDTO Payload);
        Task<Response<ListLocationAvailabilitiesRequestDTO, CorePracticeError>> ListLocationAvailabilities(ListLocationAvailabilitiesResponseDTO Payload);
        
    }
}