using apply_job_web_api.Models.Configurations;
using apply_job_web_api.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace apply_job_web_api.Models
{
    public class ApplyJobWebApiDbContext : DbContext
    {
        public DbSet<Job> jobs { set; get; }
        public DbSet<ApplyJob> applyJobs { set; get; }

        public ApplyJobWebApiDbContext(DbContextOptions<ApplyJobWebApiDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(JobConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplyJobConfiguration).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
