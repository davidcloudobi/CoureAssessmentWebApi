using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Response
{
    public class GlobalResponse<T>
    {
        public string  Message { get; set; }
        public bool Status { get; set; }
        public T Data { get; set; } 
    }
}
