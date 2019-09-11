using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lista de strings
            List<string> listaLinear = new List<string>();
            for (int i = 0; i <= 5; i++)
            {
                listaLinear.Add(i.ToString());
            }
            // Imprimindo lista com foreach
            foreach (var item in listaLinear)
            {
                Console.WriteLine(item);
            }

            // Template com string.format
            var testTemplate = @"Nome do usuario:{0} Idade: {1} Descrição:{2} Hummmmmmm{0}";
            var finishText = string.Format(testTemplate, Console.ReadLine(), Console.ReadLine(), Console.ReadLine());

            Console.WriteLine(finishText);
            Console.ReadKey();
        }
    }
}
