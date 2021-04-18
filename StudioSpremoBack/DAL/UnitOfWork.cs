using StudioSpremoBack.DAL.Repos;
using StudioSpremoBack.DAL.Services;
using StudioSpremoBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudioSpremoBack.DAL
{
  public class UnitOfWork
  {
    private DatabaseContext _context;

    private JobFlexoRepository _flexoRepo;

    private JobFlexoService _flexoService;

    public UnitOfWork(DatabaseContext context)
    {
      _context = context;

      _flexoRepo = new JobFlexoRepository(_context);
    }

    public JobFlexoService JobFlexoService
    {
      get {
        if(this._flexoService == null)
        {
          this._flexoService = new JobFlexoService(_flexoRepo);
        }
        return this._flexoService;
      }
    }
  }
}
