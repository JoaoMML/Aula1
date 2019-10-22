using FlorLibrary.Controller;
using FlorLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlorECultura
{
    class Program
    {
        static FlorController flores = new FlorController();
        static void Main(string[] args)
        {
            var opcao = int.MinValue;

            while (opcao != 0)
            {
                //Apresentação do menu inicial
                Console.WriteLine("Escolha um menu");
                Console.WriteLine("1 - Inserir Flor");
                Console.WriteLine("0 - Sair");
                //Obtemos o menu escolhido pelo usuario
                opcao = int.Parse(Console.ReadLine());
                //switch nos ajuda com a escolha da opção
                switch (opcao)
                {
                    //Caso for opção 1 ele inseri celular
                    case 1:
                        Adiciona();
                        flores.GetFlores().ToList().ForEach(x => Console.WriteLine(x.Nome));
                        break;
                    default://Casso colocar uma opção não valida 
                        Console.WriteLine("Opção inválida");
                        break;
                }
                //Colocamos true para informar que não deve aparecer na 
                //tela o valor pressionado
                Console.WriteLine("Pressione qualquer tecla para voltar ao menu inicial.");
                Console.ReadKey(true);
                Console.Clear();

            }
        }

        public static void Adiciona()
        {
            Console.Clear();
            Console.WriteLine("============================");
            Console.WriteLine("Informe o nome da flor: ");
            var nome = Console.ReadLine();
            Console.WriteLine("Informe a quantidade de flores: ");
            var quantidade = int.Parse(Console.ReadLine());

            var resultado = flores.Inserir(new Flor() { Nome = nome, Quantidade = quantidade });
        }
    }
}
