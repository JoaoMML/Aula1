using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregateLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var listNomes = new List<string>() {
                "Felipe","Juninho","Pedro","Jao","Vlad","Maicon","Daniel","Jedi"
            };

            var texto = listNomes.Aggregate((nome1, nome2) => nome1 + ";" + nome2);

            Console.WriteLine(texto);
            Console.ReadLine();
        }
    }
}
