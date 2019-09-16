using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicioList
{
    class Program
    {
        static List<string> minhaListaPulgmatica = new List<string>() {
                "Felipe",
                "Pedro",
                "Irineu"
            };

        static void Main(string[] args)
        {
            AdicionarItensAlista();
            ListaInformacoes();

            Console.ReadKey();
        }

        private static void AdicionarItensAlista()
        {
            Console.Clear();
            Console.WriteLine("Informe um nome:");
            minhaListaPulgmatica.Add(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Digite 'S' para adicionar um novo e qualquer outra tecla para sair..");
            if (Console.ReadKey().KeyChar.ToString().ToLower() == "s")
                AdicionarItensAlista();
            Console.WriteLine("");
        }

        private static void ListaInformacoes()
        {
            Console.Clear();
            Console.WriteLine("Nomes adicionados a lista");
            foreach (var item in minhaListaPulgmatica)
                Console.WriteLine($"Nome: {item} foi adicionado a lista");
        }
    }
}
