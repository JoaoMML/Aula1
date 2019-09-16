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
            ForeachComSplitLista();
        }
        /// <summary>
        /// Uso do Foreach com split
        /// </summary>
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
        /// <summary>
        /// Uso do split no foreach com listas! 
        /// </summary>
        private static void ForeachComSplitLista()
        {
            var conteudo = "nome:João,idade:19;nome:Maria,idade:29;nome:Viegas,idade:20;nome:Maicon,idade:12;nome:Pedro,idade:17";
            var nomeIdade = conteudo.Split(';');

            //foreach (var item in nomeIdade)
            //{
            //    Console.WriteLine($"{item}");
            //}

            //Console.WriteLine("Informe o nome do sistema");
            //var nomeBusca = Console.ReadLine();

            foreach (var item in nomeIdade)
            {
                var informacoesSplit = item.Split(',');

                var nome = informacoesSplit[0].Split(':')[1];
                var idade = informacoesSplit[1].Split(':')[1];

                if (int.Parse(idade) >= 18) //if(nome = nomeBusca)
                {
                    Console.WriteLine($" >> {nome} está com {idade} anos de idade!! <<");
                }
            }

            Console.ReadKey();
        }
    }
}
