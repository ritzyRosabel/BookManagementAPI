using BookManagement.Domain.API;
using BookManagement.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Domain.DBRepository
{
    class RepositoryCommand : IRepositoryCommand
    {
        public Task<Response> Create(Book model)
        {
            throw new NotImplementedException();
        }

        public Task<Response> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response> Update(Book model)
        {
            throw new NotImplementedException();
        }
    }
}
