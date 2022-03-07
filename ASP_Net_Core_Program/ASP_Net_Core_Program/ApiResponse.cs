using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Net_Core_Program
{
    public class ApiResponse<T>
    {
        public string StatusCode { get; set; }
        public string Errors{ get; set; }
        public T Response { get; set; }


    }
}
