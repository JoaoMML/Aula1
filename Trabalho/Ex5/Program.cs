using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe uma palavra");
            var texto = Console.ReadLine();
            Console.WriteLine($" Primeira: {texto[0]}\n Ultima:{texto[texto.Length - 1].ToString()}");
            Console.ReadKey();
        }
    }
}
