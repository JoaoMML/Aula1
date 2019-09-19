using CadPessoas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadPessoas
{
    class Program
    {
        static List<People> listaPessoa = new List<People>();
        static void Main(string[] args)
        {
            Menu();
        }
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("=============================");
            Console.WriteLine(">>> CADASTRO DE PESSOAS! <<<");
            Console.WriteLine("=============================");
            Console.WriteLine("1 - Adicionar Pessoa");
            Console.WriteLine("2 - Mostrar Lista");
            Console.WriteLine("3 - Sair");
            Console.WriteLine("Informe a opção desejada:");

            var option = int.Parse(Console.ReadLine());
            EscolhaUser(option);

        }
        private static void EscolhaUser(int option)
        {
            switch (option)
            {
                case 1:
                    AdicionaPessoa();
                    Menu();
                    break;
                case 2:
                    ListarPessoas();
                    Menu();
                    break;
                case 3:
                    Console.WriteLine("Flw!!");
                    Console.ReadKey();
                    return;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
        private static void AdicionaPessoa()
        {
            Console.WriteLine("Informe o nome:");
            var nome = Console.ReadLine();
            Console.WriteLine("Informe a idade:");
            var idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Infomre o sexo:");
            var sexo = char.Parse(Console.ReadLine());
            Console.WriteLine("Informe a altura:");
            var altura = double.Parse(Console.ReadLine());

            listaPessoa.Add(new People()
            {
                Nome = nome,
                Idade = idade,
                Sexo = sexo,
                Altura = altura
            });
        }
        private static void ListarPessoas()
        {
            Console.Clear();
            Console.WriteLine(">> LISTAGEM DE PESSOAS <<");
            listaPessoa.ForEach(i => Console.WriteLine($"Nome:{i.Nome}\n Idade:{i.Idade}\n Sexo:{i.Sexo}\n Altura:{i.Altura}\n ====================================="));
            Console.ReadKey();
        }
    }
}