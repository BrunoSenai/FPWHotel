using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPWHotel.Models
{
    class Funcionario
    {

        public int IdFuncionario { get; set; }

        public string NomeFuncionario { get; set; }

        public string Cpf { get; set; }

        public Endereco Endereco { get; set; }

    }
}
