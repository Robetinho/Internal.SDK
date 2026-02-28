using Internal.SDK.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.SDK.__Template
{
    public class __TemplateError : ServiceError
    {
        internal __TemplateError() { }
         
        internal override ServiceError FromException(Exception ex)
        {
            return new __TemplateError
            {
                Message = ex.Message
            };
        } 

        public __TemplateError(string message)
        {
            base.Message = message;
        } 
    }
}
