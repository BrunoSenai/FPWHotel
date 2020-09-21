using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFPW.Models
{
    [Table("Servicos")]
    class Servico
    {
        [Key]
        public int IdServico { get; set; }

        public string DescricaoServico { get; set; }

        public double ValorServico { get; set; }

    }
}
