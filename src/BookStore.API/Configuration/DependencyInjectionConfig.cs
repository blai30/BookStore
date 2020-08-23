using BookStore.Domain.Interfaces;
using BookStore.Domain.Services;
using BookStore.Infrastructure.Context;
using BookStore.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace BookStore.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<BookStoreDbContext>()
                .AddScoped<ICategoryRepository, CategoryRepository>()
                .AddScoped<IBookRepository, BookRepository>()
                .AddScoped<ICategoryService, CategoryService>()
                .AddScoped<IBookService, BookService>();

            return services;
        }
    }
}
