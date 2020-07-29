using BookManagement.Core.Interface;
using BookManagement.DAL.DataAccess;
using BookManagement.Domain.DBRepository;
using BookManagement.Service.Implementation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookManagement.API.Extensions
{
    public class ServiceExtensions
    {

        public static void AddApplicationServer(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped(typeof(IRepositoryCommand<,>),typeof( RepositoryCommand<,>));
            services.AddScoped(typeof(IRepositoryQuery<,>),typeof(RepositoryQuery<,>));

            services.AddScoped(typeof(IBookService),typeof( BookService));


        }
    }
}
