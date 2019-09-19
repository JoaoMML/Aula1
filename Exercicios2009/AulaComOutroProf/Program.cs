using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaMarcelo
{
    class Program
    {
        static void Main(string[] args)
        {
            //UsandoTryParse();
            NumerosAleatórios();
        }

        /// <summary>
        /// Como utilizar o TryParse
        /// </summary>
        private static void UsandoTryParse()
        {
            int ii = 30;
            // Conversao com tryParse
            int resultadoConversao = 00;
            // int.TryParse("145", out resultadoConversao);
            if (int.TryParse("fsfsegsg", out resultadoConversao))
            {
                Console.WriteLine("Funcionou bro");
            }
            else
            {
                Console.WriteLine("Deu ruim na conversao");
            }
            Console.ReadKey();
        }
        private static void NumerosAleatórios()
        {
            var numero = new List<int>();
            var ListaOrdenada = new HashSet<int>();

            Random rdm = new Random();

            for (int i = 0; i < 6; i++)
            {
                int valorGeradoAleatoriamente = rdm.Next(60);
                ListaOrdenada.Add(valorGeradoAleatoriamente);

                if (!numero.Contains(valorGeradoAleatoriamente))
                {
                    numero.Add(valorGeradoAleatoriamente);
                }
                else
                {
                    i--;
                }
            }
            numero.ForEach(i => Console.WriteLine(i));
            Console.WriteLine("=============================================");

            foreach (var item in ListaOrdenada)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
