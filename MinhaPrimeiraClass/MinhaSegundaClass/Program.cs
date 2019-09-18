using MinhaSegundaClass.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaSegundaClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaDeCerveja = new List<CoolerDeCervejas>();

            listaDeCerveja.Add(new CoolerDeCervejas()
            {
                Nome = "Bahama",
                Quantidade = 5
            });

            listaDeCerveja.Add(new CoolerDeCervejas()
            {
                Nome = "Skol Beats",
                Quantidade = 10
            });

            listaDeCerveja.ForEach(i => Console.WriteLine($"Nome: {i.Nome} | Quantidade:{i.Quantidade}"));
            Console.ReadKey();
        }
    }
}
