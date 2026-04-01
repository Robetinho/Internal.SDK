using Internal.SDK.AISession.DTOs; 
using Microsoft.AspNetCore.Mvc;
using Internal.SDK.Base;
using ControllerBase = Internal.SDK.Base.ControllerBase;

namespace Internal.SDK.AISession
{
    [ApiController]
    [Route("api/ai-session")] 
    public abstract class AISessionControllerBase :  ControllerBase
    {
        [Route("getReply")]
        [HttpPost]
        public async Task<IActionResult> GetReplyRoute([FromBody] MessageDto Payload)
        {
            return await  ExecuteSafeAsync (() => GetReply(Payload));
        }

        public abstract Task<string> GetReply(MessageDto Payload);

        [Route("initiateSession")]
        [HttpPost]
        public async Task<IActionResult> InitiateSessionRoute([FromBody] InitiateSessionRequestDTO Payload)
        {
            return await ExecuteSafeAsync(() => InitiateSession(Payload));
        }

        public abstract Task<MessageDto> InitiateSession(InitiateSessionRequestDTO Payload);
         

        [Route("createTrainingFile")]
        [HttpPost]
        public async Task<IActionResult> CreateTrainingFileRoute([FromBody] CreateTrainingFileRequestDTO Payload)
        {
            return await ExecuteSafeAsync(() => CreateTrainingFile(Payload));
        }

        public abstract Task<CreateTrainingFileResponseDTO> CreateTrainingFile(CreateTrainingFileRequestDTO Payload);

        [Route("addTrainingFileItemsToTrainingFile")]
        [HttpPost]
        public async Task<IActionResult> AddTrainingFileItemsToTrainingFileRoute([FromBody] AddTrainingFileItemsToTrainingFileRequestDTO Payload)
        {
            return await ExecuteSafeAsync(() => AddTrainingFileItemsToTrainingFile(Payload));
        }

        public abstract Task<bool> AddTrainingFileItemsToTrainingFile(AddTrainingFileItemsToTrainingFileRequestDTO Payload);


        [Route("generateModelFromTrainingFile")]
        [HttpPost]
        public async Task<IActionResult> GenerateModelFromTrainingFileRoute([FromBody] AddTrainingFileItemsToTrainingFileRequestDTO Payload)
        {
            return await ExecuteSafeAsync(() => GenerateModelFromTrainingFile(Payload));
        }

        public abstract Task<FineTunedModel> GenerateModelFromTrainingFile(AddTrainingFileItemsToTrainingFileRequestDTO Payload);
 
    } 
   
}
