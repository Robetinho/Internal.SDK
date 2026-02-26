using Internal.SDK.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.SDK.TextToSpeech
{
    public class TextToSpeechException : ServiceException
    {
        public TextToSpeechException(TextToSpeechError errorDetails): base(errorDetails)
        {

        }
    }
}
