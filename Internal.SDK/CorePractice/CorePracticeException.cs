using Internal.SDK.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.SDK.CorePractice
{
    public class CorePracticeException : ServiceException
    {
        public CorePracticeException(CorePracticeError errorDetails): base(errorDetails)
        {

        }
    }
}
