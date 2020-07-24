using BookManagement.Core.Interface;
using BookManagement.Core.Utility;
using BookManagement.DAL.DB;
using BookManagement.DAL.Entity;
using BookManagement.DAL.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BookManagement.Core.API;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace BookManagement.Domain.DBRepository
{
    public class RepositoryCommand<TEntity,TPrimaryKey> : IRepositoryCommand<TEntity,TPrimaryKey> where TEntity : class, IEntity<TPrimaryKey>
    {
        private readonly ApplicationDbContext _db;
        public virtual DbSet<TEntity> entities => _db.Set<TEntity>();
        public RepositoryCommand(ApplicationDbContext db)
        {
            _db = db;
            
        }

        public Task<EntityEntry<TEntity>> Create(TEntity model)
        {
            var response = entities.Add(model);
            return Task.FromResult(response);
        }

        public Task<EntityEntry<TEntity>> Delete(TPrimaryKey id)
        {
            var itemFromDB = entities.Find(id);
            
            var result = entities.Remove(itemFromDB);
            return Task.FromResult(result);
        }

        public Task<EntityEntry<TEntity>> Update(TEntity model)
        {
            var response = entities.Update(model);
            return Task.FromResult(response);
        }
        //public async Task<Response> Create(Book model)
        //{
        //    var response = Utilities.InitializeResponse();
        //    _db.Books.Add(model);
        //    await _db.SaveChangesAsync();
        //    response.Data = model;
        //    return response;
        //}

        //public Task<TEntity> Create(TEntity model)
        //{
        //    throw new NotImplementedException();
        //}

        //public async Task<Response> Delete(int id)
        //{
        //    var response = Utilities.InitializeResponse();
        //    var findBookById = _db.Books.FirstOrDefaultAsync(b => b.Id == id);
        //    if (findBookById != null)
        //    {
        //        _db.Remove(findBookById);
        //        await _db.SaveChangesAsync();
        //    }
        //    return response;
        //}

        //public Task<TEntity> Delete(TPrimaryKey id)
        //{
        //    throw new NotImplementedException();
        //}

        //public async Task<Response> Update(Book model)
        //{
        //    var response = Utilities.InitializeResponse();
        //    if (model.Id != 0)
        //    {
        //        _db.Update(model);
        //        await _db.SaveChangesAsync();
        //    }
        //    return response;
        //}

        //public Task<TEntity> Update(TEntity model)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
