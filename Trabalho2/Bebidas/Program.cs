using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bebidas
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cabecalho();
            if (Console.ReadKey().KeyChar.ToString().ToLower() == "s")
            {
                Console.Clear();
                Cabecalho();
                ListaBebidas();
            }
        }

        private static void Cabecalho()
        {
            Console.WriteLine("==============================================================");
            Console.WriteLine("                LISTA DE CERVEJAS DA AMBEV");
            Console.WriteLine("==============================================================");
            Console.WriteLine("Aperte 'S' para mostrar e qualquer outra tecla para sair!");
            Console.WriteLine("**************************************************************");
        }

        public static void ListaBebidas()
        {
            var listagemBebidas = new List<string>();
            listagemBebidas.Add("Antarctica");
            listagemBebidas.Add("Bohemia");
            listagemBebidas.Add("Brahma");
            listagemBebidas.Add("Budweiser");
            listagemBebidas.Add("Caracu");
            listagemBebidas.Add("Franziskaner");
            listagemBebidas.Add("Goose Island");
            listagemBebidas.Add("Hertog Jan");
            listagemBebidas.Add("Hoegaarden");
            listagemBebidas.Add("Leffe");
            listagemBebidas.Add("Löwenbräu");
            listagemBebidas.Add("Magnífica do Maranhão");
            listagemBebidas.Add("Norteña");
            listagemBebidas.Add("Nossa");
            listagemBebidas.Add("Skol");
            listagemBebidas.Add("Stella Artois");
            listagemBebidas.Add("Original");

            listagemBebidas.ForEach(i => Console.WriteLine(i));
            Console.Read();
        }
    }
}
