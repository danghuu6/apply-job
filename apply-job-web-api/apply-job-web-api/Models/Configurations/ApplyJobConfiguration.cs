using apply_job_web_api.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace apply_job_web_api.Models.Configurations
{
    public class ApplyJobConfiguration : IEntityTypeConfiguration<ApplyJob>
    {
        public void Configure(EntityTypeBuilder<ApplyJob> builder)
        {
            builder.HasKey(x => x.id);
            builder.HasIndex(x => x.id).IsUnique();
        }
    }
}
