using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinal.Models
{
    public class Visita
    {

        public int Id { get; set; }

        public int Id_Cliente { get; set; }
        public int Id_Casa { get; set; }


    }
}
