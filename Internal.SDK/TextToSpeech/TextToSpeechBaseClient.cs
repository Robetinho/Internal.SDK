using Internal.SDK.TextToSpeech.DTOs;
using Internal.SDK.Base;
using Internal.SDK.SystemLogger;

namespace Internal.SDK.TextToSpeech 
{

    public 
        
        class TextToSpeechBaseClient : ClientBase<TextToSpeechError>, ITextToSpeechClient 
    {   
        internal TextToSpeechBaseClient(string domain, HttpClient? httpClient = null, ISystemLoggerClient? systemLoggerClient = null  ) : base(domain, "api/text-to-speech", httpClient, systemLoggerClient) { }
         
        public async Task<Response<GetSpeechAudioDataResponseDTO, TextToSpeechError>> GetSpeechAudioData(GetSpeechAudioDataRequestDTO Payload)
        { 
            return await GetPostResponse<GetSpeechAudioDataResponseDTO>("getSpeechAudioData", Payload);
        }
    }
}
