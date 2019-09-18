using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachListLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            //ListaStrng();
            //Console.WriteLine("=================================================");
            //ListaInt();
            //Console.WriteLine("=================================================");
            ListaDecimal();
            Console.ReadKey();
        }

        /// <summary>
        /// Lista de string utilizando List e Lambda
        /// </summary>
        private static void ListaStrng()
        {
            var minhaLista = new List<string>()
            {
                "Xiomi",
                "Motorola",
                "Iphone",
                "Nokia"
            };
            minhaLista.ForEach(i => Console.WriteLine(i));
        }

        /// <summary>
        /// Lista de int utilizando lambda
        /// </summary>
        private static void ListaInt()
        {
            var listaInt = new List<int>()
            {
                1,
                2,
                3,
                4,
                5,
                6,
                7,
                8,
                9,
                10
            };
            // Ou fazer listaInt.Add(10);
            // Ou fazer listaInt.Add(11);
            // Ou fazer listaInt.Add(12);

            listaInt.ForEach(i => Console.WriteLine(i));
        }

        private static void ListaDecimal()
        {
            var listaDecimal = new List<double>()
            {
                1.0,
                2.2,
                3.7,
                4.4,
                5.6,
                6.5,
                7.6,
                8.3,
                9.1,
                41753.83
            };
            listaDecimal.ForEach(i => ConvertReal(i));
        }

        /// <summary>
        /// Metodo converte numero em real para euro,yen e BTC!
        /// </summary>
        /// <param name="numero"></param>
        private static void ConvertReal(double numero)
        {
            var euros = (numero / 4.53).ToString("C2");
            var yen = (numero * 26.43).ToString("C", CultureInfo.CreateSpecificCulture("ja-JP"));
            var bitcoins = (numero * 0.000024).ToString("N6");

            Console.WriteLine($" R${numero} reais equivalem a:");
            Console.WriteLine($" -> {euros.Replace("R", "")} EUROS ");
            Console.WriteLine($" -> {yen} Yens");
            Console.WriteLine($" -> {bitcoins} BTC");
            Console.WriteLine("");
        }

    }
}
