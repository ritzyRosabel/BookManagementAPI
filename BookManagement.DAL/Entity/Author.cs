using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookManagement.DAL.Entity
{
    public class Author:BaseEntity<int>
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Sex { get; set; }
        public DateTime BirthDate { get; set; }   
    }
}
