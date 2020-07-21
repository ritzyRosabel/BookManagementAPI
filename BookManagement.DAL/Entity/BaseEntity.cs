using BookManagement.Core.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookManagement.DAL.Entity
{
    public class BaseEntity : IEntity
    {
        public int Id { get; set; }
    }
}
