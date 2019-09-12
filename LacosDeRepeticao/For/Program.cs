using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            var nome = "Joao Marcos de Moraes Lima";
            var count = 0;
            for (int i = 0; i < nome.Length - 3; i++)
            {
                var stringBuilder = $"{nome[i - 1]}-{nome[i]}-{nome[i + 1]}";
                Console.WriteLine(stringBuilder);

                if (stringBuilder.Contains("o-a"))
                {
                    count++;
                }
                //Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}
