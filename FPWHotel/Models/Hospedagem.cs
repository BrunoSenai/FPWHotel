using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPWHotel.Models
{
    class Hospedagem
    {

        public Hospedagem()
        {
            DataEntrada = DateTime.Now;
        }

        public int IdHospedagem { get; set; }

        public Quarto Quarto { get; set; }

        public Cliente Cliente { get; set; }

        public DateTime DataEntrada { get; set; }

        public DateTime DataSaida { get; set; }

        public double PrecoFinal { get; set; }
    }
}
