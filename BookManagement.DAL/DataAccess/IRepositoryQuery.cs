using BookManagement.Domain.API;
//using BookManagement.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.DAL.DataAccess
{
    public interface IRepositoryQuery<TEntity>
    {
        Task<TEntity> Get();
        Task<TEntity> GetById(int  id);
    }
}
