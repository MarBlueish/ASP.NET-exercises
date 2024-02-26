using Microsoft.EntityFrameworkCore;
using ProjetoFinal.Data;

namespace ProjetoFinal.Models
{
    public class SeedData_Cliente
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ProjetoFinalContext(
                    serviceProvider.GetRequiredService<DbContextOptions<ProjetoFinalContext>>()))
            {
                if (context.Cliente.Any())
                {
                    return;
                }
                context.Cliente.AddRange(
                    new Cliente
                    {
                        Nome = "Ana",
                        Morada = "Rua das Flores, nº 123",
                        Telefone= 910491571
                    },
                    new Cliente
                    {
                        Nome = "João",
                        Morada = "Avenida do Sol, nº 567",
                        Telefone = 910491381
                    },
                    new Cliente
                    {
                        Nome = "Maria",
                        Morada = "Praça das Estrelas, nº 890",
                        Telefone = 910491000
                    },
                    new Cliente
                    {
                        Nome = "Pedro",
                        Morada = "Travessa da Lua, nº 234",
                        Telefone = 910859184
                    },
                    new Cliente
                    {
                        Nome = "Sofia",
                        Morada = "Alameda dos Sonhos, nº 678",
                        Telefone = 931048279
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}

