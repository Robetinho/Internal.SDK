using Internal.SDK.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.SDK.__Template
{
    public class __TemplateException : ServiceException
    {
        public __TemplateException(__TemplateError errorDetails): base(errorDetails)
        {

        }
    }
}
