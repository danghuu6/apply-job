using apply_job_web_api.Models.Entities;
using apply_job_web_api.Models.Enums;

namespace apply_job_web_api.Models.DTOs
{
    public class JobDTO : BaseEntity
    {
        public Guid id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public JobType type { get; set; }
        public Status status { get; set; }
    }
}
