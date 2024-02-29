using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ativ9_Projeto.Models;

namespace Ativ9_Projeto.Data
{
    public class Ativ9_ProjetoContext : DbContext
    {
        public Ativ9_ProjetoContext (DbContextOptions<Ativ9_ProjetoContext> options)
            : base(options)
        {
        }

        public DbSet<Viatura> Viatura { get; set; } = default!;

        public DbSet<Funcionario>? Funcionario { get; set; }

        public DbSet<Cliente>? Cliente { get; set; }
        public object Clientes { get; internal set; }
    }
}
