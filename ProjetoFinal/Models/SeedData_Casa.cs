using Microsoft.EntityFrameworkCore;
using ProjetoFinal.Data;

namespace ProjetoFinal.Models
{
    public class SeedData_Casa
    {
            public static void Initialize(IServiceProvider serviceProvider)
            {
                using (var context = new ProjetoFinalContext(
                        serviceProvider.GetRequiredService<DbContextOptions<ProjetoFinalContext>>()))
                {
                    if (context.Casa.Any())
                    {
                        return;
                    }
                    context.Casa.AddRange(
                        new Casa
                        {
                            Zona = "Norte",
                            N_Assoalhadas = 3,
                            Ano = 2012,
                            Preco = 150000,
                            Id_Cliente = 1
                        },
                        new Casa
                        {
                            Zona = "Centro",
                            N_Assoalhadas = 6,
                            Ano = 2010,
                            Preco = 200000,
                            Id_Cliente = 2
                        },
                        new Casa
                        {
                            Zona = "Lisboa e Vale do Tejo",
                            N_Assoalhadas = 1,
                            Ano = 2005,
                            Preco = 250000,
                            Id_Cliente = 3
                        },
                        new Casa
                        {
                            Zona = "Alentejo",
                            N_Assoalhadas = 9,
                            Ano = 2022,
                            Preco = 300000,
                            Id_Cliente = 4
                        },
                        new Casa
                        {
                            Zona = "Algarve",
                            N_Assoalhadas = 4,
                            Ano = 2024,
                            Preco = 700000,
                            Id_Cliente = 5
                        }
                        );
                    context.SaveChanges();
                }
            }
        }
    }

