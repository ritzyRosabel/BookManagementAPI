using BookManagement.DAL.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace BookManagement.API.Extensions
{
    public static class DatabaseExtensions
    {
        public static void  AddDatabaseService( this IServiceCollection services, IConfiguration configuration)
        {
        }
    }
}
