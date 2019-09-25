using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageLinq
{
    class Program
    {
        static void Main(string[] nargs)
        {
            var listaVendas = new List<Venda>(){
                new Venda() {
                    Produto =" HotWhelss" ,
                    Quantidade = 50,
                    Valor = 5.00
                },
                new Venda() {
                    Produto =" Vibrador da sua mae",
                    Quantidade = 20,
                    Valor = 10000

                },
                new Venda(){Produto = "Xiominimi", Quantidade = 20,Valor = 1400}
            };

            Console.WriteLine($"A media da qnt de produts eh: {listaVendas.Average(i => i.Quantidade)} e do valor eh: {listaVendas.Average(i => i.Valor).ToString("C")} ");
            Console.ReadLine();
        }
    }
}
