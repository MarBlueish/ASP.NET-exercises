using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoFinal.Models;

namespace ProjetoFinal.Data
{
    public class ProjetoFinalContext : DbContext
    {
        public ProjetoFinalContext (DbContextOptions<ProjetoFinalContext> options)
            : base(options)
        {
        }

        public DbSet<ProjetoFinal.Models.Cliente> Cliente { get; set; } = default!;

        public DbSet<ProjetoFinal.Models.Interesse>? Interesse { get; set; }

        public DbSet<ProjetoFinal.Models.Casa>? Casa { get; set; }

        public DbSet<ProjetoFinal.Models.Visita>? Visita { get; set; }
    }
}
