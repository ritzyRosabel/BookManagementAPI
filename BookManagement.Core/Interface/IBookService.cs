
using BookManagement.Core.API;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BookManagement.
namespace BookManagement.Core.Interface
{
    public interface IBookService<TEntity>
    {
        Task<Response> GetBooks();
        Task<Response> GetBookByID(int id);
        Task<Response> CreateBooks(BookRequest book);
        Task<Response> UpdateABook(Book book);
        Task<Response> DeleteABook(int bookID);

    }
}
