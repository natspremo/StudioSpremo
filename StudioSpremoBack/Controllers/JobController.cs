using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudioSpremoBack.DAL;
using StudioSpremoBack.Models;

namespace StudioSpremoBack.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class JobController : ControllerBase
  {
    private DatabaseContext _context;
    UnitOfWork _unitOfWork;

    public JobController(DatabaseContext context)
    {
      _context = context;
      _unitOfWork = new UnitOfWork(_context);
    }

    [HttpPost]
    [Route("AddJobFlexo")]
    public async Task<Object> AddJobFlexo(JobFlexoModel model)
    {
      _unitOfWork = new UnitOfWork(_context);
      try
      {
        var result = _unitOfWork.JobFlexoService.AddJob(model);
        return Ok(result);
      }
      catch(Exception ex)
      {
        throw ex;
      }
    }
  }
}
