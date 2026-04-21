using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.SDK.TextToSpeech.Errors
{
    public class InvalidRequestError : TextToSpeechError
    {  
        public string? Field { get; init; }
    }
}
