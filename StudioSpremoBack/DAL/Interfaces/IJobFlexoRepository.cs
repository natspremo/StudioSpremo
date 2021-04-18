using StudioSpremoBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudioSpremoBack.DAL.Interfaces
{
  public interface IJobFlexoRepository
  {
    Task<Object> AddJob(JobFlexo job);
    IEnumerable<JobFlexo> GetAllJobs();
  }
}
