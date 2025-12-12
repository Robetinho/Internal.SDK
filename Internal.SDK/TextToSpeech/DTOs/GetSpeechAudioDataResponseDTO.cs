using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.SDK.TextToSpeech.DTOs
{
    public class GetSpeechAudioDataResponseDTO
    { 
        public required string Text { get; init; }

        public required string VoiceId { get; init; }

        public string Bitrate { get; init; } = "192k";

        public double Pitch { get; init; } = 1.02;

        public double Speed { get; init; } = 0.0;
    }
}
