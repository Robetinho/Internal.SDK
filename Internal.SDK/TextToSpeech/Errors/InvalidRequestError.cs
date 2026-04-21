using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.SDK.TextToSpeech.Errors
{
    internal class InvalidRequestError : TextToSpeechError
    {  
        public required string Field { get; init; }
    }
}
