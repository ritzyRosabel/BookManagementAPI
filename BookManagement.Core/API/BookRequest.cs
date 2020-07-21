using System;
using System.Collections.Generic;
using System.Text;

namespace BookManagement.Core.API
{
    public class BookRequest
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }
}
