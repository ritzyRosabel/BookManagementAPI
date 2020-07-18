using BookManagement.Domain.API;
using BookManagement.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Core.Interface
{
    public interface IBookService
    {
        Task<Response> GetBooks();
        Task<Response> CreateBooks(BookRequest book);
        Task<Response> UpdateABook(int bookID);
        Task<Response> DeleteABook(int bookID);

    }
}
