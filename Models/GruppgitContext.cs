using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GruppNrSexAPI.Models;

namespace GruppNrSexAPI.Models
{
    public class GruppgitContext : DbContext
    {
        
        public DbSet<Sponsor> Sponsors { get; set; }
        public GruppgitContext(DbContextOptions options) : base (options)
        {

        }
        

        
    }
}
