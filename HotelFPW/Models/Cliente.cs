using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFPW.Models
{
    [Table("Clientes")]
    class Cliente
    {
        [Key]
        public int IdCliente { get; set; }

        public string NomeCliente { get; set; }

        public string Cpf { get; set; }

        public string Email { get; set; }

    }
}
