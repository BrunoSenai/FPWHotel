using System;

namespace Testes
{
    class Program
    {
        static void Main(string[] args)
        {
            // AQUI TESTES SERÃO EXECUTADOS PARA AUXILIAR O PROJETO FINAL

            if (Validacao.ValidarCpf("111.111.111-11"))
            {
                Console.WriteLine("CPF VALIDO");
            }

            DataAndDinheiros.CalcularDifDatas();

            Console.ReadKey();
        }
    }
}
