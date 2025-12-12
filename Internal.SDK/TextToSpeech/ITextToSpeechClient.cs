using Internal.SDK.TextToSpeech.DTOs;
using Internal.SDK.Base;

namespace Internal.SDK.TextToSpeech
{
    public interface ITextToSpeechClient
    {
        Task<Response<GetSpeechAudioDataResponseDTO>> GetSpeechAudioData(GetSpeechAudioDataRequestDTO Payload);
    }
}