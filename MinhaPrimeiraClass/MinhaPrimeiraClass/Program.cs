using MinhaPrimeiraClass.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaPrimeiraClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaDeBicicleta = new List<Bicicleta>
            {
                new Bicicleta()
                {
                    Marca = "Honda"
                },
                new Bicicleta()
                {
                    Marca = "Caloi"
                },
                new Bicicleta()
                {
                    Marca = "BmZ"
                },
                new Bicicleta()
                {
                    Marca = "AhTabom"
                }
            };

            listaDeBicicleta.ForEach(i => Console.WriteLine($"BikeON => Marca: {i.Marca} Pneus:{i.Pneus}"));
            Console.ReadKey();
        }
    }
}
