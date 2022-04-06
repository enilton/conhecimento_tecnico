using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IEL_Application.Models;

namespace IEL_Application.Data
{
    public class IEL_ApplicationContext : DbContext
    {
        public IEL_ApplicationContext (DbContextOptions<IEL_ApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<IEL_Application.Models.Profissional> Profissional { get; set; }

        public DbSet<IEL_Application.Models.DiaDeTrabalho> DiaDeTrabalho { get; set; }
    }
}
