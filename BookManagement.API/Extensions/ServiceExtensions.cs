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
    public static class  ServiceExtensions
    {

        public static void AddApplicationServer(this IServiceCollection services, IConfiguration configuration)
        {
            


        }
    }
}
