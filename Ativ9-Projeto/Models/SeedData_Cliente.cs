using Ativ9_Projeto.Data;
using Microsoft.EntityFrameworkCore;
using Ativ9_Projeto.Models;

namespace Ativ9_Projeto.Models
{
    public class SeedData_Cliente
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Ativ9_ProjetoContext(
            serviceProvider.GetRequiredService<DbContextOptions<Ativ9_ProjetoContext>>()))
            {
                if (context.Cliente.Any())
                {
                    return;
                }

                context.Cliente.AddRange(
new Cliente
{
    
    Nome = "Maria Oliveira",
    Morada = "Rua da Esperança, 456",
    Data_Nasc = "1985-05-15",
    Email = "maria.oliveira@example.com",
    Telefone = 912345678
},
new Cliente
{
    
    Nome = "António Sousa",
    Morada = "Avenida Principal, 789",
    Data_Nasc = "1990-08-22",
    Email = "antonio.sousa@example.com",
    Telefone = 923456789
},
new Cliente
{
    
    Nome = "Sofia Martins",
    Morada = "Travessa das Flores, 101",
    Data_Nasc = "1982-03-10",
    Email = "sofia.martins@example.com",
    Telefone = 934567890
},
new Cliente
{
    
    Nome = "José Silva",
    Morada = "Largo Central, 202",
    Data_Nasc = "1978-11-05",
    Email = "jose.silva@example.com",
    Telefone = 945678901
},
new Cliente
{
    
    Nome = "Marta Pereira",
    Morada = "Praça da Liberdade, 303",
    Data_Nasc = "1989-07-18",
    Email = "marta.pereira@example.com",
    Telefone = 956789012
}



                );

                context.SaveChanges();
            }
        }
    }
}
