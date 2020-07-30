using BookManagement.Core.API;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Core.Interface
{
    public interface IAuthorService
    {
        Task<Response> Get();
        Task<Response> GetById(int id);
        Task<Response> CreateAuthor(AuthorCreateRequest book);
        Task<Response> UpdateAuthor(UpdateAuthorRequest book);
        Task<Response> Delete(int bookID);
    }
}
