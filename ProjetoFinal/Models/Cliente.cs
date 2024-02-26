using System.ComponentModel.DataAnnotations;

namespace ProjetoFinal.Models
{
    public class Cliente
    {

        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Morada { get; set; }
        public long Telefone { get; set; }



    }
}
