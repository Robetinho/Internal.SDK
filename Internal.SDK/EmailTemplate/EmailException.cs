using Internal.SDK.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.SDK.Email
{
    public class EmailException : ServiceException
    {
        public EmailException(EmailError errorDetails): base(errorDetails)
        {

        }
    }
}
