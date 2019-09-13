using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Informe um texto:");
            var text = Console.ReadLine();
            Console.WriteLine("==============================================================");
            Console.WriteLine($" O texto original: {text} ");
            Console.WriteLine("==============================================================");
            Console.WriteLine($" O texto replaced: {text.Replace("Banana", "Laranja")} ");
            Console.WriteLine("\n Digite algo para finalizar..");
            Console.ReadKey();
        }
    }
}
