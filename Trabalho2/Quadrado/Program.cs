using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a medida do lado do quadrado:");
            var lado = int.Parse(Console.ReadLine());
            Console.WriteLine($"A area do quadrado é :{ lado * lado}");
            Console.ReadKey();
        }
    }
}
