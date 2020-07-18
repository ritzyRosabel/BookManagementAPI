using BookManagement.Domain.API;
using BookManagement.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Domain.DBRepository
{
    public interface IRepositoryQuery
    {
        Task<Response> Get();
        Task<Response> GetById(int  id);
    }
}
