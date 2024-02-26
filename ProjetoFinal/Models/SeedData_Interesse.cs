using Microsoft.EntityFrameworkCore;
using ProjetoFinal.Data;

namespace ProjetoFinal.Models
{
    public class SeedData_Interesse
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ProjetoFinalContext(
                    serviceProvider.GetRequiredService<DbContextOptions<ProjetoFinalContext>>()))
            {
                if (context.Interesse.Any())
                {
                    return;
                }
                context.Interesse.AddRange(
                    new Interesse
                    {
                        Zona ="Norte",
                        N_Assoalhadas = 3,
                        Id_Cliente = 1
                    },
                    new Interesse
                    {
                        Zona = "Centro",
                        N_Assoalhadas = 6,
                        Id_Cliente = 2
                    },
                    new Interesse
                    {
                        Zona = "Lisboa e Vale do Tejo",
                        N_Assoalhadas = 1,
                        Id_Cliente = 3
                    },
                    new Interesse
                    {
                        Zona = "Alentejo",
                        N_Assoalhadas = 9,
                        Id_Cliente = 4
                    },
                    new Interesse
                    {
                        Zona = "Algarve",
                        N_Assoalhadas = 4,
                        Id_Cliente = 5
                    }
                    
                    );
                context.SaveChanges();
            }
        }
    }
}

