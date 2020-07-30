using BookManagement.Core.API;
using BookManagement.Core.Interface;
using BookManagement.DAL.DataAccess;
using BookManagement.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Service.Implementation
{
    public class AuthorService
    {
        private readonly IRepositoryCommand<Author, int> _repositoryCommand;
        private readonly IRepositoryQuery<Author, int> _repositoyQuery;
        public AuthorService(IRepositoryCommand<Author, int> repositoryCommand, IRepositoryQuery<Author, int> repositoryQuery)
        {
            _repositoryCommand = repositoryCommand;
            _repositoyQuery = repositoryQuery;
        }

        public async Task<Response> Get()
        {
            var response = new Response();
            var result = await _repositoyQuery.Get();
            response.Data = result;
            return response; 
        }
        public async Task<Response> GetById( int id)
        {
            var response = new Response();
            var result = await _repositoyQuery.GetById(id);
            response.Data = result;
            return response;

        }

    }
}
