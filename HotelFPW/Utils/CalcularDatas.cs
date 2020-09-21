using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFPW.Utils
{
    class CalcularDatas
    {

        public static int CalcularDiferencaDatas()
        {
            DateTime DataPassada = new DateTime(2020, 09, 10, 13, 30, 52);
            DateTime DataAgr = DateTime.Now;

            TimeSpan Date = DataAgr - DataPassada;

            return (int)Date.Days;
        }


    }
}
