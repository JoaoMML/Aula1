using System;

namespace ExerCarros
{
    class Program
    {
        static void Main(string[] args)
        {
            var conteudo = "carro:Gol,marca:volkswagen,ano:2000;carro:Jetta,marca:volkswagen,ano:2012;carro:Sportage,marca:Kia,ano:2011;carro:Hb20,marca:hyundai,ano:2015";
            Console.WriteLine("Informe o nome do carro!");
            var nomeFiltro = Console.ReadLine();
            var individualInformations = conteudo.Split(';');
            foreach (var item in individualInformations)
            {
                var infoSplit = item.Split(',');
                var nome = infoSplit[0].Split(':')[1];
                var marca = infoSplit[1].Split(':')[1];
                var ano = infoSplit[2].Split(':')[1];

                if (nome == nomeFiltro)
                    Console.WriteLine($"O carro selecionado eh da marca: {marca} e do ano {ano} ");
            }
            Console.ReadKey();
        }
    }
}
