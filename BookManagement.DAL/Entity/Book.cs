using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookManagement.DAL.Entity
{
   public class Book:BaseEntity<int>
    {

        public string Name { get; set; }
        public string Author { get; set; }
        public string ISBN  { get; set; }
    }
}
