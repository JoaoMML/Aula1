using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoCelulares.Controller;
using CatalogoCelulares.Model;

namespace CellDu
{
    class Program
    {
        static CelularesController celulares = new CelularesController();
        static void Main(string[] args)
        {
            //Definimos uma opção de menu inicial
            var opcao = int.MinValue;
            //Definimos que enquanto for diferente de 0 
            //Ele continua em nosso loop
            while (opcao != 0)
            {
                //Apresentação do menu inicial
                Console.WriteLine("Escolha um menu");
                Console.WriteLine("1 - Inserir Celular");
                Console.WriteLine("0 - Sair");
                //Obtemos o menu escolhido pelo usuario
                opcao = int.Parse(Console.ReadLine());
                //switch nos ajuda com a escolha da opção
                switch (opcao)
                {
                    //Caso for opção 1 ele inseri celular
                    case 1:
                        InserirCelular();
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

        public static void InserirCelular()
        {
            Console.WriteLine("_*_* INSERIR CELULAR _*_*");
            Console.WriteLine("Informe a marca");
            var marca = Console.ReadLine();
            Console.WriteLine("Informe o modelo:");
            var modelo = Console.ReadLine();
            Console.WriteLine("Informe o preço:");
            var preco = double.Parse(Console.ReadLine());

            var resultado = celulares.InserirCelular(new Celular()
            {
                Marca = marca,
                Modelo = modelo,
                Preco = preco
            });
        }
    }
}
