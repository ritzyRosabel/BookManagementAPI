using BookManagement.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Domain.DBRepository
{
    public interface IRepositoryQuery
    {
        Task<Book> Get();
        Task<Book> GetById(int  id);
    }
}
