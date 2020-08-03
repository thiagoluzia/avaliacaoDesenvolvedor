using Lanchonete.App;
using Lanchonete.App.Interface;
using Lanchonete.Infra.Data;
using Lanchonete.Interfaces.Repos;
using Lanchonete.Interfaces.Services;
using Lanchonete.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Lanchonete.Infra.IoC
{
    public static class DependencyResolver
    {

        public static void AddInjectionContainer(this IServiceCollection services)
        {
            AddApplicationContainer(services);
            AddServicesContainer(services);
            AddRepositoriesContainer(services);
        }

        private static void AddApplicationContainer(IServiceCollection services)
        {
            services.AddScoped<IProdutoApp, ProdutoApp>();
            services.AddScoped<ICategoriaApp, CategoriaApp>();
        }

        private static void AddServicesContainer(IServiceCollection services)
        {
            services.AddScoped<IProdutoService, ProdutoService>();
            services.AddScoped<ICategoriaService, CategoriaService>();
        }

        private static void AddRepositoriesContainer(IServiceCollection services)
        {
            services.AddScoped<IProdutoRepo, ProdutoRepo>();
            services.AddScoped<ICategoriaRepo, CategoriaRepo>();
        }

    }
}
