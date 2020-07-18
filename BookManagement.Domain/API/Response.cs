using System;
using System.Collections.Generic;
using System.Text;

namespace BookManagement.Domain.API
{
    public class Response
    {
        public string RequestId { get; set; }
        public string RequestCode { get; set; }
        public string RequestMessage { get; set; }
        public Object Data { get; set; }
    }
}
