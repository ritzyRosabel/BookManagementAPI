using BookManagement.Domain.API;
using BookManagement.Domain.DB;
using BookManagement.Domain.Entity;
using BookManagement.Domain.Utility;
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
        public async Task<Response> Get()
        {
            var response = Utilities.InitializeResponse();
            response.Data =  await _db.Books.ToListAsync();
            return response;
        }

        public async Task<Response> GetById(int id)
        {
            var response = Utilities.InitializeResponse();
            response.Data =  await _db.Books.FirstOrDefaultAsync(B=>B.Id==id);
            return response;
        
        }
    }
}
