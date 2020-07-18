using BookManagement.Domain.API;
using BookManagement.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookManagement.Core.Interface
{
    public interface IBookService
    {
        Response GetBooks();
        Response CreateBooks(BookRequest book);
        Response UpdateABook(int bookID);
        Response DeleteABook(int bookID);

    }
}
