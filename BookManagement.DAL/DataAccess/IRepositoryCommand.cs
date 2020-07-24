using BookManagement.Core.API;
using BookManagement.Core.Interface;
using BookManagement.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.DAL.DataAccess
{
    public interface IRepositoryCommand<TEntity,TPrimaryKey> where TEntity : class,IEntity<TPrimaryKey>
    {
        Task<TEntity> Create(TEntity model);
        Task<TEntity> Update(TEntity model);
        Task<TEntity> Delete(TPrimaryKey id);
    }
} 
