using Microsoft.EntityFrameworkCore;
using StudioSpremoBack.DAL.Interfaces;
using StudioSpremoBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudioSpremoBack.DAL.Repos
{
  public class JobFlexoRepository : IJobFlexoRepository
  {
    DatabaseContext _context;
    public JobFlexoRepository(DatabaseContext context)
    {
      _context = context;
    }
    public async Task<Object> AddJob(JobFlexo job)
    {
      _context.JobsFlexo.Add(job);
      var result = await _context.SaveChangesAsync();
      return result;
    }

    public IEnumerable<JobFlexo> GetAllJobs()
    {
      var jobs = _context.JobsFlexo
                        .Include(a => a.PolymerThickness)
                        .Include(b => b.FilePaths);
      return jobs;
    }
  }
}
