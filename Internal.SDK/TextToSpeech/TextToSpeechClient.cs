using Internal.SDK.TextToSpeech.DTOs;
using Internal.SDK.Base;

namespace Internal.SDK.TextToSpeech 
{

    public class TextToSpeechClient : ClientBase, ITextToSpeechClient
    {   
        public TextToSpeechClient(HttpClient httpClient) : base("http://localhost:5004/", "api/text-to-speech", httpClient) { }
         
        public TextToSpeechClient() : this(null!) { } 
           
        public async Task<Response<GetSpeechAudioDataResponseDTO>> GetSpeechAudioData(GetSpeechAudioDataRequestDTO Payload)
        {
            return await GetPostResponse<GetSpeechAudioDataResponseDTO>("getSpeechAudioData", Payload);
        }
    }
}
