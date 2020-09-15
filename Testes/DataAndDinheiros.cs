using System;
using System.Collections.Generic;
using System.Text;

namespace Testes
{
    class DataAndDinheiros
    {
        //String format para mostrar dinheiros na tela
        //Console.WriteLine(String.Format(new CultureInfo("pt-BR"), "{0:C}", precoFinal));

        public static void CalcularDifDatas()
        {

            DateTime DataPassada = new DateTime(2020, 09, 10, 13, 30, 52);
            DateTime DataAgr = DateTime.Now;

            TimeSpan Date = DataAgr - DataPassada;

            int totalDias = Date.Days;

            Console.WriteLine("Total dias: " + totalDias);

        }



    }
}
