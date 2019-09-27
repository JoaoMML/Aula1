using ListagemDeCervejas.Controller;
using ListagemDeCervejas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicaçaoModoON
{
    class Program
    {
        static CervejaController cervejaController = new CervejaController();
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo, voce é corno!");
            ListarCervejas();
            // Console.WriteLine("_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_\n");
            //AdicionaCerveja();
            //Console.WriteLine("_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_\n");
            //ListarCervejas();
            Console.WriteLine("_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_\n");
            Console.WriteLine("Valor total valores lista: " + ValorTotalList().ToString("C"));
            Console.WriteLine("Valor total litros lista: " + ValorTotalLitros());


            Console.ReadLine();
        }

        public static void ListarCervejas()
        {
            cervejaController.GetCervejas().ForEach(i => Console.WriteLine($@"
                 Id: {i.Id.ToString()}
                 Nome: {i.Nome}
                 Ml: {i.LitrosEmMl}
                 % Alcoolico:{i.PercentAlcoolPerMl}
                 Valor: {i.Valor.ToString("C")}
                 =====================================
            "));
        }

        public static void AdicionaCerveja()
        {
            try
            {
                Console.WriteLine("Adicionar cerveja!! \n");

                Console.WriteLine("Informe o nome da breja:");
                var nome = Console.ReadLine();
                Console.WriteLine("Informe os Ml's");
                var litrosEmMl = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o percentual alcoolico:");
                var percenteAlcool = double.Parse(Console.ReadLine());
                Console.WriteLine("Informe o valor:");
                var valor = double.Parse(Console.ReadLine());

                cervejaController.AddCervejas(new Cerveja()
                {
                    Id = cervejaController.GetCervejas().Count + 1,
                    Nome = nome,
                    LitrosEmMl = litrosEmMl,
                    PercentAlcoolPerMl = percenteAlcool,
                    Valor = valor
                });
            }
            catch (Exception)
            {

                throw new Exception("Ta informando os dados errado o fela da put*");
            }

        }

        public static double ValorTotalList()
        {
            return cervejaController.GetCervejas().Sum(i => i.Valor);
        }
        public static int ValorTotalLitros()
        {
            return cervejaController.GetCervejas().Sum(i => i.LitrosEmMl);
        }
    }
}
