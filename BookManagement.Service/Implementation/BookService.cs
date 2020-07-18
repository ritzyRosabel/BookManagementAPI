using BookManagement.Core.Interface;
using BookManagement.Domain.API;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Service.Implementation
{
    public class BookService : IBookService
    {
      //  private IReq
        public BookService()
        {

        }
        public Task<Response> CreateBooks(BookRequest book)
        {
            throw new NotImplementedException();
        }

        public Task<Response> DeleteABook(int bookID)
        {
            throw new NotImplementedException();
        }

        public async Task<Response> GetBooks()
        {
            return await _repositoryQuery.Get();    
        }

        public Task<Response> UpdateABook(int bookID)
        {
            throw new NotImplementedException();
        }
    }
}
