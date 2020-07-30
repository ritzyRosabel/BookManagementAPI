using BookManagement.Core.Interface;
using BookManagement.DAL.DataAccess;
using BookManagement.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookManagement.Service.Implementation
{
    public class AuthorService
    {
        private readonly IRepositoryCommand<Author,int> _repositoryCommand;
        private readonly IRepositoryQuery<Author,int> _repositoyQuery;
        public AuthorService(IRepositoryCommand<Author,int>repositoryCommand,IRepositoryQuery<Author,int> repositoryQuery)
        {
            _repositoryCommand = repositoryCommand;
            _repositoyQuery = repositoryQuery;
        }
    }
}
