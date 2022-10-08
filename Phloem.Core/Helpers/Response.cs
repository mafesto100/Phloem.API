using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phloem.Core.Helpers
{
    public class Response<T>
    {
        public string? Message { get; private set; }
        public T? Data { get; private set; }
        public bool Status { get; private set; }

        public Response(T? data, string? message = null, bool status = true)
        {
            Message = message;
            Data = data;
            Status = status;
        }
    }
}
