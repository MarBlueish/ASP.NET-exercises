using Microsoft.EntityFrameworkCore;
using ProjetoFinal.Data;

namespace ProjetoFinal.Models
{
    public class SeedData_Visita
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ProjetoFinalContext(
                    serviceProvider.GetRequiredService<DbContextOptions<ProjetoFinalContext>>()))
            {
                if (context.Visita.Any())
                {
                    return;
                }
                context.Visita.AddRange(
                    new Visita
                    {
                        Id_Cliente = 1,
                        Id_Casa = 1
                    },
                    new Visita
                    {
                        Id_Cliente = 2,
                        Id_Casa = 2
                    },
                    new Visita
                    {
                        Id_Cliente = 3,
                        Id_Casa = 3
                    },
                    new Visita
                    {
                        Id_Cliente = 4,
                        Id_Casa = 4
                    },
                    new Visita
                    {
                        Id_Cliente = 5,
                        Id_Casa = 5
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
