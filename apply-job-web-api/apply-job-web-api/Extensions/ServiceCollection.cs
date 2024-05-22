using apply_job_web_api.Models;
using Microsoft.EntityFrameworkCore;

namespace apply_job_web_api.Extensions
{
    public static class ServiceCollection
    {
        public static IServiceCollection AddSqlPersistence(this IServiceCollection services, string connectionString) 
        {
            services.AddDbContext<ApplyJobWebApiDbContext>(options =>
            {
                options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            });

            return services;
        }
    }
}
