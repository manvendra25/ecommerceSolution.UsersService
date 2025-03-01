using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerce.Infrastructure.DbContext;
using eCommerce.Infrastructure.Repositories;
using ecommerceCore.RepositoryContracts;
using Microsoft.Extensions.DependencyInjection;
namespace eCommerce.Infrastructure;

    public static  class DependencyInjection
    {
     public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddTransient<IUsersRepository, UsersRepository>();
        services.AddTransient<DapperDbContext>();

        return services;

    }
    }

