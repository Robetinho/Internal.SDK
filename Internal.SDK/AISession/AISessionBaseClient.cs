using Internal.SDK.AISession.DTOs;
using Internal.SDK.Base;
using Internal.SDK.SlackMessenger;
using Internal.SDK.SystemLogger;
using Microsoft.AspNetCore.Mvc;

namespace Internal.SDK.AISession
{

    public abstract class AISessionBaseClient : ClientBase<AISessionError>, IAISessionClient
    {
        internal AISessionBaseClient(string domain, HttpClient? httpClient = null, ISystemLoggerClient? systemLoggerClient = null) : base(domain, "api/ai-session", httpClient, systemLoggerClient) { }


        public async Task<Response<string, AISessionError>> GetReply(GetReplyRequestDTO Payload)
        {
            return await GetPostResponse<string>("getReply", Payload);
        }

        public async Task<Response<string, AISessionError>> GetSingleReply(GetSingleReplyRequestDTO Payload)
        {
            return await GetPostResponse<string>("getSingleReply", Payload);
        }

        public async Task<Response<MessageDto, AISessionError>> InitiateSession(InitiateSessionRequestDTO Payload)
        { 
            return await GetPostResponse<MessageDto>("initiateSession", Payload);
        }

        public async Task<Response<CreateTrainingFileResponseDTO, AISessionError>> CreateTrainingFile(CreateTrainingFileRequestDTO Payload)
        {
            return await GetPostResponse<CreateTrainingFileResponseDTO>("createTrainingFile", Payload);
        }

        public async Task<Response<bool, AISessionError>> AddTrainingFileItemsToTrainingFile(AddTrainingFileItemsToTrainingFileRequestDTO Payload)
        {
            return await GetPostResponse<bool>("addTrainingFileItemsToTrainingFile", Payload);
        }

        public async Task<Response<FineTunedModelDTO, AISessionError>> GenerateModelFromTrainingFile(GenerateModelFromTrainingFileDTO Payload)
        {
            return await GetPostResponse<FineTunedModelDTO>("generateModelFromTrainingFile", Payload);
        }

        public async Task<Response<FineTunedModelDTO, AISessionError>> GetFineTunedModel(GetFineTunedModelRequestDTO Payload)
        {
            return await GetPostResponse<FineTunedModelDTO>("getFineTunedModel", Payload);
        }

        public async Task<Response<TrainingFileDTO, AISessionError>> GetTrainingFile(GetTrainingFileRequestDTO Payload)
        {
            return await GetPostResponse<TrainingFileDTO>("getTrainingFile", Payload);
        }
    }
}
