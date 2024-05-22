using apply_job_web_api.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace apply_job_web_api.Models.Entities
{
    public class Job : BaseEntity
    {
        [Key]
        public Guid id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public JobType type { get; set; }
        public Status status { get; set; }

        //relationship
        public ICollection<ApplyJob> applyJobs { get; set; }

        public Job()
        {
            applyJobs = new List<ApplyJob>();
        }
    }
}
