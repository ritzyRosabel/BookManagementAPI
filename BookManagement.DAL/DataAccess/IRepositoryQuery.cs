//using BookManagement.Domain.Entity;
using BookManagement.Core.API;
using BookManagement.Core.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BookManagement.Core.Interface;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace BookManagement.DAL.DataAccess
{
    public interface IRepositoryQuery<TEntity,TPrimaryKey> where TEntity : class, IEntity<TPrimaryKey>
    {
        Task<EntityEntry<TEntity>> Get();
        Task<EntityEntry<TEntity>> GetById(TPrimaryKey  id);
    }
}
