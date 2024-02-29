using System.ComponentModel.DataAnnotations;
using System.IO.Pipes;
using System.Reflection.Metadata;

namespace Ativ9_Projeto.Models
{
    public class Viatura
    {
        public int ID { get; set; }
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public string? Cor { get; set; }
        public int Cilindrada { get; set; }
        public int Ano { get; set; }
        [Display(Name = "Mês")]
        public int Mes { get; set; }
        public string? Tipo { get; set; }
        [Display(Name = "Preço")]
        public decimal Preco { get; set; }
        [Display(Name = "Forma de Pagamento")]
        public string? ForPgto { get; set; }
    }// a continuar, ja realizado scaffold a esta pagina
}
