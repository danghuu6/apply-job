using apply_job_web_api.Commons.Contants;
using apply_job_web_api.Commons.Responses;
using apply_job_web_api.Models;
using apply_job_web_api.Models.DTOs;
using apply_job_web_api.Models.Entities;
using apply_job_web_api.Models.Enums;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace apply_job_web_api.Repositories.Impl
{
    public class JobRepository : IJobRepository
    {
        private readonly ApplyJobWebApiDbContext _context;
        private readonly IMapper _mapper;

        public JobRepository(ApplyJobWebApiDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Response<JobDTO>> CreateJobAsync(JobDTO dto)
        {
            if (!Enum.IsDefined(typeof(JobType), dto.type))
            {
                return Response<JobDTO>.Error(Contant.JOB_TYPE_INVALID);
            }

            if (!Enum.IsDefined(typeof(Status), dto.status))
            {
                return Response<JobDTO>.Error(Contant.STATUS_INVALID);
            }

            dto.id = Guid.NewGuid();
            var newJob = _mapper.Map<Job>(dto);
            
            try
            {
                await _context.Jobs.AddAsync(newJob);
                await _context.SaveChangesAsync();
                return Response<JobDTO>.Success(dto, Contant.SUCCESS);
            }
            catch(DbUpdateException e)
            {
                Console.WriteLine(e.Message);
                return Response<JobDTO>.Error(e.Message);
            } 
        }
    }
}
