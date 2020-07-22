using BookManagement.Core.Interface;
using BookManagement.Core.Utility;
using BookManagement.DAL.DB;
using BookManagement.DAL.Entity;
using BookManagement.Domain.API;
using BookManagement.DAL.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Domain.DBRepository
{
    public class RepositoryCommand : IRepositoryCommand
    {
        private readonly ApplicationDbContext _db;
        public RepositoryCommand(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<Response> Create(Book model)
        {
            var response = Utilities.InitializeResponse();
            _db.Books.Add(model);
            await _db.SaveChangesAsync();
            response.Data = model;
            return response;
        }

        public async Task<Response> Delete(int id)
        {
            var response = Utilities.InitializeResponse();
            var findBookById = _db.Books.FirstOrDefaultAsync(b => b.Id == id);
            if (findBookById != null)
            {
                _db.Remove(findBookById);
                await _db.SaveChangesAsync();
            }
            return response;
        }

        public async Task<Response> Update(Book model)
        {
            var response = Utilities.InitializeResponse();
            if (model.Id != 0)
            {
                _db.Update(model);
                await _db.SaveChangesAsync();
            }
            return response;
        }
    }
}
