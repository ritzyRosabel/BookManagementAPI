//using BookManagement.Domain.Entity;
using BookManagement.Core.API;
using BookManagement.Core.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace BookManagement.DAL.DataAccess
{
    public interface IRepositoryQuery<TEntity,TPrimaryKey> where TEntity : class, IEntity<TPrimaryKey>
    {
        Task<List<TEntity>> Get();
        Task<TEntity> GetById(TPrimaryKey  id);
    }
}
