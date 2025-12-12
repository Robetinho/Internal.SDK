using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.SDK.TextToSpeech.DTOs
{
    public class GetSpeechAudioDataRequestDTO
    { 
        public required string AudioData64 { get; init; } 
    }
}
