using apply_job_web_api.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace apply_job_web_api.Models.Configurations
{
    public class JobConfiguration : IEntityTypeConfiguration<Job>
    {
        public void Configure(EntityTypeBuilder<Job> builder)
        {
            builder.HasKey(x => x.id);
            builder.HasIndex(x => x.id).IsUnique();
            builder.HasMany(x => x.applyJobs)
                .WithOne(x => x.job)
                .HasForeignKey(x => new { x.id })
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
