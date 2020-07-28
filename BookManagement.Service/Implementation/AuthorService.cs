using BookManagement.Core.Interface;
using BookManagement.DAL.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookManagement.Service.Implementation
{
    public class AuthorService
    {
        private readonly IRepositoryCommand<TEntity,TPrimaryKey> _repositoryCommand;
        private readonly IRepositoryQuery _repositoyQuery;
    }
}
