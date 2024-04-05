using Microsoft.EntityFrameworkCore;
using TestChallenge.Data;

namespace TestChallenge.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureServices(this IServiceCollection services, IConfiguration config) 
        {
            services.AddDbContext<RepositoryContext>(o =>
            o.UseSqlServer(config.GetConnectionString("sqlConnection")
            , options => options.MigrationsAssembly("TestChallenge")));
        }
    }
}
