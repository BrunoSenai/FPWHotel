using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFPW.Models
{
    [Table("Funcionarios")]
    class Funcionario
    {
        [Key]
        public int IdFuncionario { get; set; }

        public string NomeFuncionario { get; set; }

        public string Cpf { get; set; }

        public Endereco Endereco { get; set; }

    }
}
