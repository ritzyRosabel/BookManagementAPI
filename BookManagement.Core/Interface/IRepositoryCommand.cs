using BookManagement.Domain.API;
using BookManagement.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Core.Interface
{
    public interface IRepositoryCommand
    {
        Task<Response> Create(Book model);
        Task<Response> Update(Book model);
        Task<Response> Delete(int id);
    }
} 
