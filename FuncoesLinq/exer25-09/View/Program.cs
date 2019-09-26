using exer25_09.Controller;
using exer25_09.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer25_09
{
    class Program
    {
        public static CarrosController carrosController = new CarrosController();
        static void Main(string[] args)
        {
            {
                MostraMenu();
                Console.WriteLine("Banco de dados:");
                carrosController.GetCarros().ForEach(i => Console.WriteLine(i));
                Console.ReadKey();
            }
        }

        private static void MostraMenu()
        {
            Console.Clear();
            Console.WriteLine("============== MENU 1.0 ==============");
            Console.WriteLine("1  - Por mes");
            Console.WriteLine("0 -  Sair");

            var menuEscolha = int.MinValue;

            while (menuEscolha != 0)
            {
                menuEscolha = int.Parse(Console.ReadLine());

                switch (menuEscolha)
                {
                    case 1:
                        Console.WriteLine("Informe o mês para realizar o filtro");
                        //Obtemos a informação do mês
                        var mesEscolhido = int.Parse(Console.ReadLine());
                        //Passamos o mes na mesma função para obter as vendas
                        var listaDoPeriodoEscolhido = carrosController.GetCarros(mesEscolhido);

                        //Aqui imprimimos as informações para o usuario
                        listaDoPeriodoEscolhido.ForEach(i => ImprimeInformacoes(i));

                        var totalMes = listaDoPeriodoEscolhido
                            //Somamos todos os registro multiplicando as valor venda vezes a quantidade 
                            .Sum(x => x.Valor * x.Quantidade);

                        var mediaPeriodo = listaDoPeriodoEscolhido
                            //Média de todos os registro multiplicando as valor venda vezes a quantidade 
                            .Average(x => x.Valor * x.Quantidade);

                        //Mostramos o mes escolhido e o valor total neste mês gerado
                        Console.WriteLine($"Total do mês {mesEscolhido} é {totalMes.ToString("C")}");
                        //Mostramos o mes escolhido e o valor médio de vendas no mes gerado
                        Console.WriteLine($"Média do mês {mesEscolhido} é {mediaPeriodo.ToString("C")}");

                        Console.ReadKey();
                        break;
                    default:
                        break;
                }

            }
        }
        public static void ImprimeInformacoes(CarroModel carro)
        {
            Console.WriteLine(
                string.Format("Id {0,3} Carro {1,-35} Valor {2,-10} Quantidade {3,3} Data {4,12}"
                , carro.Id
                , carro.Nome
                , carro.Valor.ToString("C")
                , carro.Quantidade
                , carro.Ano.ToShortDateString()));
        }
    }
}

