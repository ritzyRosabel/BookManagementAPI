using BookManagement.Core.Interface;
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
            services.AddScoped<IRepositoryCommand, RepositoryCommand>();
            services.AddScoped<IRepositoryQuery, RepositoryQuery>();

            services.AddScoped<IBookService, BookService>();


        }
    }
}
