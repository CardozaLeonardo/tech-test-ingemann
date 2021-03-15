using Application.Interfaces;
using Application.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Context;
using Persistence.Repositories;

namespace Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceLayer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(
                /*"Server=;Database=TechTest;Trusted_Connection=True;MultipleActiveResultSets=true;",*/
                "Server=leocode.database.windows.net,1433;Initial Catalog=TechTest;User ID=leocode;Password=Leo@123456",
                b => b.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName)));

            #region Repositories

            services.AddScoped(typeof(IGenericRepositoryAsync<>), typeof(GenericRepositoryAsync<>));
            services.AddScoped<IItemRepositoryAsync, ItemRepositoryAsync>();
            services.AddScoped<IInvoiceRepositoryAsync, InvoiceRepositoryAsync>();

            #endregion
        }
    }
}
