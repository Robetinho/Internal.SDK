using Internal.SDK.TextToSpeech.DTOs;
using Internal.SDK.Base;
using Internal.SDK.SystemLogger;

namespace Internal.SDK.TextToSpeech 
{

    public class TextToSpeechClient : ClientBase, ITextToSpeechClient
    {   
        public TextToSpeechClient(HttpClient? httpClient = null, ISystemLoggerClient? systemLoggerClient = null) : base("http://localhost:5004/", "api/text-to-speech", httpClient, systemLoggerClient) { }
          
           
        public async Task<Response<GetSpeechAudioDataResponseDTO>> GetSpeechAudioData(GetSpeechAudioDataRequestDTO Payload)
        {
            return await GetPostResponse<GetSpeechAudioDataResponseDTO>("getSpeechAudioData", Payload);
        }
    }
}
