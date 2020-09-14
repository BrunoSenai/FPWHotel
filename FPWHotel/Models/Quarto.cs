using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPWHotel.Models
{
    [Table("Quartos")]
    class Quarto
    {
        [Key]
        public int IdQuarto { get; set; }

        public int NumeroQuarto { get; set; }

        public double PrecoDiaria { get; set; }

        public int NumCamasSolteiro { get; set; }

        public int NumCamasCasal { get; set; }

        public string Descricao { get; set; }

        public Boolean Ocupado { get; set; }

    }
}
