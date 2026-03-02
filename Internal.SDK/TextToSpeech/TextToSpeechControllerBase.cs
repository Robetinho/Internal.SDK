using Internal.SDK.TextToSpeech.DTOs; 
using Microsoft.AspNetCore.Mvc;
using Internal.SDK.Base;
using ControllerBase = Internal.SDK.Base.ControllerBase;

namespace Internal.SDK.TextToSpeech
{
    [ApiController]
    [Route("api/text-to-speech")] 
    public abstract class TextToSpeechControllerBase :  ControllerBase
    {
        [Route("getSpeechAudioData")]
        [HttpPost]
        public async Task<IActionResult> GetSpeechAudioDataRoute([FromBody] GetSpeechAudioDataRequestDTO Payload)
        {
            return await  ExecuteSafeAsync(() => GetSpeechAudioData(Payload));
        }

        public abstract Task<GetSpeechAudioDataResponseDTO> GetSpeechAudioData(GetSpeechAudioDataRequestDTO Payload);
         
    }  
}
