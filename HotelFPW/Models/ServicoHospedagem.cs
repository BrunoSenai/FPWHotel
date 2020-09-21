using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFPW.Models
{
    [Table("ServicosHospedagens")]
    class ServicoHospedagem
    {
        [Key]
        public int IdSH { get; set; }

        public Hospedagem Hospedagem { get; set; }

        public Servico Servico { get; set; }


    }
}
