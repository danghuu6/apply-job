using apply_job_web_api.Models.Entities;

namespace apply_job_web_api.Models.DTOs
{
    public class ApplyJobDTO : BaseEntity 
    { 
        public Guid id { get; set; }
        public string fullName { get; set; }
        public string contact { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string currentSalary { get; set; }
        public string expectedSalary { get; set; }
        public string resumFile { get; set; }
    }
}
