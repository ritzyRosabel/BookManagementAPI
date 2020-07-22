using BookManagement.Domain.API;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.DAL.DataAccess
{
    public interface IRepositoryCommand
    {
        Task<Response> Create(Book model);
        Task<Response> Update(Book model);
        Task<Response> Delete(int id);
    }
} 
