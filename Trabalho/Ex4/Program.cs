using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um texto: ");
            var qntTextoUsuario = Console.ReadLine().Length;
            Console.WriteLine($"O texto informado possui: {qntTextoUsuario} caracteres!!");
            EndMensage();
        }
        public static void EndMensage()
        {
            Console.WriteLine("Digite qualquer tecla para sair..");
            Console.ReadKey();
        }
    }
}
