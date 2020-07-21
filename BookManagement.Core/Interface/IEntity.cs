using System;
using System.Collections.Generic;
using System.Text;

namespace BookManagement.Core.Interface
{
    public interface IEntity<Int>
    {
        Int Id { get; set; }
    }
}
