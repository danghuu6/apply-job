using apply_job_web_api.Commons.Responses;
using apply_job_web_api.Models.DTOs;

namespace apply_job_web_api.Repositories
{
    public interface IJobRepository
    {
        public Task<Response<JobDTO>> CreateJobAsync(JobDTO dto);
    }
}
