using BookManagement.Core.API;
using BookManagement.Core.Interface;
using BookManagement.DAL.Entity;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.DAL.DataAccess
{
    public interface IRepositoryCommand<TEntity,TPrimaryKey> where TEntity : class,IEntity<TPrimaryKey>
    {
        Task<EntityEntry<TEntity>> Create(TEntity model);
        Task<EntityEntry<TEntity>> Update(TEntity model);
        Task<EntityEntry<TEntity>> Delete(TPrimaryKey id);
    }
} 
