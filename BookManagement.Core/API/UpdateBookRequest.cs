﻿using BookManagement.Core.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookManagement.Core.API
{
    public class UpdateBookRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }
}
