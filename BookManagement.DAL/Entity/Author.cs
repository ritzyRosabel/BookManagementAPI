using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookManagement.DAL.Entity
{
    public class Author
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Sex { get; set; }
        public DateTime BirthDate { get; set; }    `
    }
}
