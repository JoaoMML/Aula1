using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicioForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            // ForeachComSplit();
        }

        private static void ForeachComSplit()
        {
            Console.WriteLine("Informe seu nome:");
            var conteudoTexto = $@"Aqui;temos;um;texto;que;iremos;mudar;para;uma;coleçãoe; vamos; colocar; isto;{Console.ReadLine()};para;depois;usar;com;o;replace";

            Console.WriteLine("Informe a palavra para realizar a busca:");
            var palavra = Console.ReadLine();

            var conteudoSplit = conteudoTexto.Split(';');

            foreach (var item in conteudoSplit)
            {
                if (palavra == item)
                    Console.WriteLine("Palavra encontrada com sucess!!");
            }
            Console.ReadKey();
        }
    }
}
