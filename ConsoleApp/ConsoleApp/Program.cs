using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var saldo = 0.00;
            var valor = 0.00;

            Console.WriteLine("============ BANCO DO JOÃO =====================");
            Console.WriteLine("1 - DEPOSITAR");
            Console.WriteLine("2 - SACAR");
            Console.WriteLine("3 - MOSTRAR SALDO");
            Console.WriteLine("0 - SAIR");
            Console.WriteLine("=================================");
            Console.WriteLine(" **** Informe a opcão desejada: ****");
            var opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Informe o valor para depositar: ");
                    valor = Convert.ToDouble(Console.ReadLine());
                    saldo += valor;
                    break;
                case "2":
                    break;
                case "3":
                    Console.WriteLine("O saldo eh de:" + saldo);
                    break;
                //case "0":
                //    Console.WriteLine("Até a proxima!");
                //    Console.ReadKey();
                //    break;
                default:
                    Console.WriteLine("Opcao invalida!!");
                    break;
            }
        }
    }
}
