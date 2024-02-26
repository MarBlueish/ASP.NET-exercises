using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinal.Models
{
    public class Interesse
    {

        public int Id { get; set; }
        public string? Zona { get; set; }
        public int N_Assoalhadas { get; set; }
        public int Id_Cliente { get; set; }


    }


}

