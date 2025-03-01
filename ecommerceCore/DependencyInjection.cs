
using ecommerceCore.ServiceContracts;
using ecommerceCore.Services;
using Microsoft.Extensions.DependencyInjection;
using FluentValidation.AspNetCore;
using FluentValidation;
using ecommerceCore.Validators;

namespace ecommerceCore;

    public static class DependencyInjection
    {
        public static IServiceCollection AddCore(this IServiceCollection services)
        {
        //TO DO: Add services to the IoC container
        //Core services often include data access, caching and other low-level components.

        services.AddTransient<IUsersService, UsersService>();
        services.AddValidatorsFromAssemblyContaining<LoginRequestValidator>();
        return services;

    }
    }