using apply_job_web_api.Models.DTOs;
using apply_job_web_api.Models.Entities;
using AutoMapper;

namespace apply_job_web_api.Commons.Helpers
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            CreateMap<Job, JobDTO>().ReverseMap();
            CreateMap<ApplyJob, ApplyJobDTO>().ReverseMap();
        }
    }
}
