using System;
using System.Collections.Generic;
using System.Text;

namespace BookManagement.Core.API
{
    public class AuthorCreateRequest
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Sex { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
