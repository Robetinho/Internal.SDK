using Internal.SDK.AISession.DTOs;
using Internal.SDK.Base;
using Microsoft.AspNetCore.Mvc;

namespace Internal.SDK.AISession
{
    public interface IAISessionClient
    {
        Task<Response<string, AISessionError>> GetReply(GetReplyRequestDTO Payload);

        Task<Response<string, AISessionError>> GetSingleReply(GetSingleReplyRequestDTO Payload);

        Task<Response<MessageDto, AISessionError>> InitiateSession(InitiateSessionRequestDTO Payload);

        Task<Response<CreateTrainingFileResponseDTO, AISessionError>> CreateTrainingFile(CreateTrainingFileRequestDTO Payload);

        Task<Response<bool, AISessionError>> AddTrainingFileItemsToTrainingFile(AddTrainingFileItemsToTrainingFileRequestDTO Payload);

        Task<Response<FineTunedModelDTO, AISessionError>> GenerateModelFromTrainingFile(GenerateModelFromTrainingFileDTO Payload);

        Task<Response<FineTunedModelDTO, AISessionError>> GetFineTunedModel(GetFineTunedModelRequestDTO Payload);

        Task<Response<TrainingFileDTO, AISessionError>> GetTrainingFile(GetTrainingFileRequestDTO Payload);
    }
}