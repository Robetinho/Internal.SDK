using Internal.SDK.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.SDK.TextToSpeech
{
    public class TextToSpeechError : ServiceError
    {
        internal TextToSpeechError() { }
         
        internal override ServiceError FromException(Exception ex)
        {
            return new TextToSpeechError
            {
                Message = ex.Message
            };
        } 

        public TextToSpeechError(string message)
        {
            base.Message = message;
        } 
    }
}
