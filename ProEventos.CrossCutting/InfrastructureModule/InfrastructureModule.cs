using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProEventos.Application.Interfaces;
using ProEventos.Application.Services;
using ProEventos.Core.Interfaces.Repository;
using ProEventos.Data.DatabaseContext;
using ProEventos.Data.Repositories;

namespace ProEventos.CrossCutting.InfrastructureModule
{
    public static class InfrastructureModule
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddRepositories();

            services.AddDbContext<ApplicationDbContext>(opts =>
            {
                string connectionSql = configuration.GetConnectionString("ProEventosCs")!;
                opts.UseSqlServer(connectionSql);

            });

            return services;
        }

        private static IServiceCollection AddRepositories(this IServiceCollection services)
        {

            services.AddScoped(typeof(IEventRepository), typeof(EventoRepository));
            services.AddScoped(typeof(IEventService), typeof(EventService));


            return services;
        }
    }
}
