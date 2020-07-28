using BookManagement.Core.API;
using BookManagement.Core.Interface;
using BookManagement.DAL.DataAccess;
using BookManagement.DAL.Entity;
using BookManagement.Domain.DBRepository;
using System;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Service.Implementation
{
    public class BookService<TEntity> : IBookService
    {
        private readonly IRepositoryQuery<Book,int> _repositoryQuery;
        private readonly  IRepositoryCommand<Book, int> _repositoryCommand;
        public BookService(IRepositoryCommand<Book, int> repositoryCommand,IRepositoryQuery<Book, int> repositoryQuery)
        {
            _repositoryCommand = repositoryCommand;
            _repositoryQuery = repositoryQuery;
        }
        public async Task<Response> CreateBooks(BookRequest book)
        {
            Response response = new Response();
            var bookToCreate = new Book()
            {
                Id = 0,
                Name = book.Name,
                Author = book.Author,
                ISBN = book.ISBN
            };
            var result =  await _repositoryCommand.Create(bookToCreate);
            response.Data = result;
            return response;
        }

        public async Task<Response> DeleteABook(int bookID)
        {
            Response response = new Response();

            if (bookID == 0)
            {
                return response;
            }
                var result = await _repositoryCommand.Delete(bookID);
            response.Data = result;
            return response;
        }

        public async Task<Response> GetBookByID(int id)
        {
            Response response = new Response();

            if (id == 0)
            {
                return response;
            }

            var result =  await _repositoryQuery.GetById(id);
            response.Data = result;
            return response;
        }

        public async Task<Response> GetBooks()
        {
            Response response = new Response();
            var result = await  _repositoryQuery.Get();
            response.Data = result;
            return response;
        }

        public async Task<Response> UpdateABook(UpdateBookRequest book)
        {
            Response response = new Response();
            Book books = new Book()
            {
                Id = book.Id,
                Name = book.Name,
                Author = book.Author,
                ISBN = book.ISBN
            };

            var result =  await _repositoryCommand.Update(books);
            response.Data = result;
            return response;
        }
    }
}
