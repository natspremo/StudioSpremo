using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudioSpremoBack.Models
{
    public class DatabaseContext : IdentityDbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Courier> Couriers { get; set; }
        public DbSet<PolymerThickness> PolymerThicknesses { get; set; }
        public DbSet<PlateDimension> PlateDimensions { get; set; }
        public DbSet<User> Staff { get; set; }

    }
    
}
