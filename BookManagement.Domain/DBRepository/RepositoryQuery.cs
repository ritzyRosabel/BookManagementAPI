using BookManagement.Domain.DB;
using BookManagement.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Domain.DBRepository
{
    public class RepositoryQuery : IRepositoryQuery
    {
        private readonly ApplicationDbContext _db;
        public RepositoryQuery(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<List<Book>> Get()
        {
            return await _db.Books.ToListAsync();
        }

        public Task<Book> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
