using StudioSpremoBack.DAL.Repos;
using StudioSpremoBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudioSpremoBack.DAL.Services
{
  public class JobFlexoService
  {
    JobFlexoRepository _repo;

    public JobFlexoService(JobFlexoRepository repo)
    {
      _repo = repo;
    }

    public async Task<Object> AddJob(JobFlexoModel jobModel)
    {

      JobFlexo job = new JobFlexo     //nema brOtpremnice i filepaths ucitan
      {
        JobName = jobModel.JobName,
        IsDone = false,
        CourierIncluded = jobModel.CourierIncluded,
        FileShortening = jobModel.FileShortening,
        MaterialType = jobModel.MaterialType,
        Montage = jobModel.Montage,
        Liniature = jobModel.Liniature,
        Note = jobModel.Note,
        ObimValjka = jobModel.ObimValjka,
        OrderedTime = DateTime.Now,
        OverprintBlack = jobModel.OverprintBlack,
        PolymerThicknessId = jobModel.PolymerThicknessId,
        Prepress = jobModel.Prepress,
        RollWidth = jobModel.RollWidth,
        SeparationSum = jobModel.SeparationSum,
        ServiceId = jobModel.ServiceId
      };
      var result = _repo.AddJob(job);

      return result;
    }

    public List<Object> GetAllJobs()
    {
      var jobs = _repo.GetAllJobs();
      List<Object> _jobs = new List<Object>();
      foreach (var job in jobs)
      {
        var temp_job = new      // nije ubacen file paths
        {
          job.JobName,
          job.Id,
          job.IsDone,
          job.Liniature,
          job.MaterialType,
          job.Montage,
          job.Note,
          job.ObimValjka,
          job.OrderedTime,
          job.OverprintBlack,
          job.PolymerThickness,
          job.Prepress,
          job.RadniNalog,
          job.RollWidth,
          job.SeparationSum,
          job.Service
        };
        _jobs.Add(temp_job);
      }
      return _jobs;
    }
  }
}
