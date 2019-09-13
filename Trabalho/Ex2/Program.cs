using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o seu nome:");
            var nome = Console.ReadLine();
            WelcomeMensage(nome);
            EndMensage();

        }
        private static void WelcomeMensage(string nome)
        {
            Console.WriteLine("==============================================");
            Console.WriteLine($"** SEJA BEM VINDO, {nome} !!");
            Console.WriteLine("==============================================");
        }

        public static void EndMensage()
        {
            Console.WriteLine("Digite qualquer tecla para sair..");
            Console.ReadKey();
        }
    }
}
