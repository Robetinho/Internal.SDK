using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.SDK.Base
{
    public class Response<T>
    {
        public T Item { get; set; }

        public bool IsSuccess { get; set; }

        public int ResponseCode { get; set; }
    }

}
