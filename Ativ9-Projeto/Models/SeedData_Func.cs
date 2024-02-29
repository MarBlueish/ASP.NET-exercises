using Ativ9_Projeto.Data;
using Microsoft.EntityFrameworkCore;
using Ativ9_Projeto.Models;

namespace Ativ9_Projeto.Models
{
    public class SeedData_Func
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Ativ9_ProjetoContext(
            serviceProvider.GetRequiredService<DbContextOptions<Ativ9_ProjetoContext>>()))
            {
                if (context.Funcionario.Any())
                {
                    return;
                }

                context.Funcionario.AddRange(
                    new Funcionario
                    {
                        
                        Nmr_Func = 25625,
                        Nome = "João Silva",
                        Morada = "Rua das Flores, 123",
                        email = "joao.silva@example.com",
                        Telefone = 912345678,
                        Nib = 234561234,
                        Contribuinte = 123456789
                    },
                    new Funcionario
                    {
                        
                        Nmr_Func = 25626,
                        Nome = "Ana Sousa",
                        Morada = "Avenida Central, 456",
                        email = "ana.sousa@example.com",
                        Telefone = 923456789,
                        Nib = 345612345,
                        Contribuinte = 234567890
                    },
                    new Funcionario
                    {
                        
                        Nmr_Func = 25627,
                        Nome = "Carlos Oliveira",
                        Morada = "Travessa dos Pinheiros, 789",
                        email = "carlos.oliveira@example.com",
                        Telefone = 934567890,
                        Nib = 456123456,
                        Contribuinte = 345678901
                    },
                    new Funcionario
                    {
                        
                        Nmr_Func = 25628,
                        Nome = "Marta Santos",
                        Morada = "Largo da Fonte, 101",
                        email = "marta.santos@example.com",
                        Telefone = 945678901,
                        Nib = 567123456,
                        Contribuinte = 456789012
                    },
                    new Funcionario
                    {
                        
                        Nmr_Func = 25629,
                        Nome = "Rui Costa",
                        Morada = "Praça da Liberdade, 202",
                        email = "rui.costa@example.com",
                        Telefone = 956789012,
                        Nib = 678123456,
                        Contribuinte = 567890123
                    }
                ); 

                context.SaveChanges();
            }
        }
    }
}
