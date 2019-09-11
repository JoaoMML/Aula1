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
            var point = 1;
            while (point != 0)
            {
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
                        _ = Depositar(ref saldo);
                        break;
                    case "2":
                        _ = Sacar(ref saldo);
                        break;
                    case "3":
                        MostrarSaldo(saldo);
                        break;
                    case "0":
                        point = 0;
                        Console.WriteLine("Informe qualquer tecla para sair..");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opcao invalida!!");
                        break;
                }
            }
        }

        private static void MostrarSaldo(double saldo)
        {
            Console.WriteLine("O saldo eh de:" + saldo.ToString("C") + "\n");
            Console.WriteLine("** Digite algo para voltar ao menu **");
            Console.ReadKey();
        }

        private static double Sacar(ref double saldo)
        {
            double valor;
            Console.WriteLine("Informe o valor para sacar:");
            valor = Convert.ToDouble(Console.ReadLine());
            if (saldo >= valor)
            {
                saldo -= valor;
                Console.WriteLine("Operação realizada com sucesso!");
            }
            else
            {
                Console.WriteLine("Limite não disponivel!, voce possui: " + saldo.ToString("C") + "\n");
            }

            return valor;
        }

        private static double Depositar(ref double saldo)
        {
            double valor;
            Console.WriteLine("Informe o valor para depositar: ");
            valor = Convert.ToDouble(Console.ReadLine());
            saldo += valor;
            Console.WriteLine("Operação realizada com sucesso!");
            return valor;
        }
    }
}
