using BookManagement.Core.API;
using BookManagement.Domain.API;
//using BookManagement.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Core.Interface
{
    public interface IBookService<IEntity>
    {
        Task<Response> GetBooks();
        Task<Response> GetBookByID(int id);
        Task<Response> CreateBooks(BookRequest book);
        Task<Response> UpdateABook(Book<> book);
        Task<Response> DeleteABook(int bookID);

    }
}
