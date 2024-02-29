using Ativ9_Projeto.Data;
using Microsoft.EntityFrameworkCore;
using Ativ9_Projeto.Models;

namespace Ativ9_Projeto.Models
{
    public class SeedData_Viat
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Ativ9_ProjetoContext(
            serviceProvider.GetRequiredService<DbContextOptions<Ativ9_ProjetoContext>>()))
            {
                if (context.Viatura.Any())
                {
                    return;
                }

                context.Viatura.AddRange(
                    new Viatura
                {
                
    Marca = "Volkswagen",
    Modelo = "Golf",
    Cor = "Branco",
    Cilindrada = 1600,
    Ano = 2021,
    Mes = 2,
    Tipo = "Hatchback",
    Preco = 22000,
    ForPgto = "A pronto pagamento"
},
new Viatura
{
    
    Marca = "Peugeot",
    Modelo = "208",
    Cor = "Prateado",
    Cilindrada = 1200,
    Ano = 2023,
    Mes = 3,
    Tipo = "Hatchback",
    Preco = 20000,
    ForPgto = "A pronto pagamento"
},
new Viatura
{
    
    Marca = "Ford",
    Modelo = "Focus",
    Cor = "Preto",
    Cilindrada = 1600,
    Ano = 2022,
    Mes = 4,
    Tipo = "Sedan",
    Preco = 23000,
    ForPgto = "A pronto pagamento"
},
new Viatura
{
    
    Marca = "Opel",
    Modelo = "Corsa",
    Cor = "Vermelho",
    Cilindrada = 1400,
    Ano = 2020,
    Mes = 5,
    Tipo = "Hatchback",
    Preco = 19000,
    ForPgto = "A pronto pagamento"
},
new Viatura
{
    
    Marca = "Seat",
    Modelo = "Ibiza",
    Cor = "Cinza",
    Cilindrada = 1300,
    Ano = 2023,
    Mes = 6,
    Tipo = "Hatchback",
    Preco = 21000,
    ForPgto = "A pronto pagamento"
}
                );

                context.SaveChanges();
            }
        }
    }
}
