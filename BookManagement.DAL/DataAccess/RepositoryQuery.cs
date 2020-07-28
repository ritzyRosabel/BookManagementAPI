
using BookManagement.Core.API;
using BookManagement.Core.Interface;
using BookManagement.Core.Utility;
using BookManagement.DAL.DataAccess;
using BookManagement.DAL.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Domain.DBRepository
{
    public class RepositoryQuery<TEntity, TPrimaryKey> : IRepositoryQuery<TEntity,TPrimaryKey> where TEntity:class,IEntity<TPrimaryKey>
    {
        private readonly ApplicationDbContext _db;
        public virtual DbSet<TEntity> entities =>_db.Set<TEntity>();
        public RepositoryQuery(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<List<TEntity>> Get()
        {
            var result = await entities.ToListAsync();
            return result;

        }

        public async Task<TEntity> GetById(TPrimaryKey id)
        {
            var result =await entities.FindAsync(id);
            return result;
        
        }
    }
}
