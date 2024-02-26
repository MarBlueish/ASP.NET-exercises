using Microsoft.AspNetCore.Http.Features;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace ProjetoFinal.Models
{
    public class Casa
    {
        public int Id { get; set; }
        public string? Zona { get; set; }
        public int N_Assoalhadas { get; set; }
        public int Ano { get; set; }
        public int Preco { get; set; }
        public int Id_Cliente { get; set; }




    }
}
