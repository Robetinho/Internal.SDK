using Internal.SDK.AISession.DTOs;
using Internal.SDK.Base;

namespace Internal.SDK.AISession
{
    public interface IAISessionClient
    {
        Task<Response<string, AISessionError>> GetReply(MessageDto Payload);

        Task<Response<MessageDto, AISessionError>> InitiateSession(InitiateSessionRequestDTO Payload);

        Task<Response<CreateTrainingFileResponseDTO, AISessionError>> CreateTrainingFile(CreateTrainingFileRequestDTO Payload);

        Task<Response<bool, AISessionError>> AddTrainingFileItemsToTrainingFile(AddTrainingFileItemsToTrainingFileRequestDTO Payload);

        Task<Response<FineTunedModelDTO, AISessionError>> GenerateModelFromTrainingFile(GenerateModelFromTrainingFileDTO Payload);
    }
}