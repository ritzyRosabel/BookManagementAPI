using BookManagement.Core.Interface;
using BookManagement.Domain.API;
using BookManagement.Domain.DBRepository;
using BookManagement.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Service.Implementation
{
    public class BookService : IBookService
    {
        private readonly IRepositoryQuery _repositoryQuery;
        private readonly  IRepositoryCommand _repositoryCommand;
        public BookService(IRepositoryCommand repositoryCommand,IRepositoryQuery repositoryQuery)
        {
            _repositoryCommand = repositoryCommand;
            _repositoryQuery = repositoryQuery;
        }
        public async Task<Response> CreateBooks(BookRequest book)
        {
            var bookToCreate = new Book()
            {
                Id = 0,
                Name = book.Name,
                Author = book.Author,
                ISBN = book.ISBN
            };
            return await _repositoryCommand.Create(bookToCreate);
        }

        public async Task<Response> DeleteABook(int bookID)
        {
            return await _repositoryCommand.Delete(bookID);
        }

        public async Task<Response> GetBookByID(int id)
        {
            return await _repositoryQuery.GetById(id);
        }

        public async Task<Response> GetBooks()
        {
            return await  _repositoryQuery.Get();   
        }

        public async Task<Response> UpdateABook(Book book)
        {
            return await _repositoryCommand.Update(book);
        }
    }
}
