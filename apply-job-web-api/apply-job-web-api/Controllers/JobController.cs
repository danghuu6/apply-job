using apply_job_web_api.Commons.Responses;
using apply_job_web_api.Models.DTOs;
using apply_job_web_api.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apply_job_web_api.Controllers
{
    [Route("api/job")]
    [ApiController]
    public class JobController : ControllerBase
    {
        private readonly IJobRepository _jobRepository;

        public JobController(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Create(JobDTO jobDTO)
        {
            var response = await _jobRepository.CreateJobAsync(jobDTO);

            if (response == null || response.Status == ResponseStatus.Error)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }
    }
}
