using Exercicio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            var listPessoa = new List<Pessoa>()
            {
                new Pessoa()
                {
                    Id = 1,
                    Nome ="Ana",
                    DataNascimento = DateTime.Parse("23/09/2001"),
                    Carteira = 800.0
                },
                new Pessoa()
                {
                    Id = 2,
                    Nome ="Zaerk",
                    DataNascimento = DateTime.Parse("22/09/2001"),
                    Carteira = 300.0
                },
                new Pessoa()
                {
                    Id = 3,
                    Nome ="Jao",
                    DataNascimento = DateTime.Parse("24/09/2001"),
                    Carteira = 100.0
                },
                new Pessoa()
                {
                    Id = 4,
                    Nome = "Kevin O Cris",
                    DataNascimento = DateTime.Parse("21/05/2004"),
                    Carteira = 5000.0
                },
                new Pessoa()
                {
                    Id = 1,
                    Nome = "Spears",
                    DataNascimento = DateTime.Parse("07/11/2004"),
                    Carteira = 846.96
                },
                new Pessoa()
                {
                    Id = 2,
                    Nome = "Swanson",
                    DataNascimento = DateTime.Parse("20/06/2003"),
                    Carteira = 233.09
                },
                new Pessoa()
                {
                    Id = 3,
                    Nome = "Gay",
                    DataNascimento = DateTime.Parse("03/12/2001"),
                    Carteira = 911.92
                }
            };

            Console.WriteLine("ORDENADO POR NOME CRESC");
            listPessoa.OrderBy(x => x.Nome).ToList<Pessoa>().ForEach(i => Console.WriteLine($"Id: {i.Id} Nome: {i.Nome} DataNascimento: {i.DataNascimento.ToString("dd-MM-yyyy")}"));

            Console.WriteLine("==========================================================================================");
            Console.WriteLine("ORDENADO POR DATA NASC DESC");
            listPessoa.OrderByDescending(x => x.DataNascimento).ToList<Pessoa>().ForEach(i => Console.WriteLine($"Id: {i.Id} Nome: {i.Nome} DataNascimento: {i.DataNascimento.ToString("dd-MM-yyyy")}"));

            Console.WriteLine("==========================================================================================");
            Console.WriteLine("CARTEIRA > 500 DOL");
            listPessoa.Where(x => x.Carteira > 500).ToList().ForEach(i => Console.WriteLine($"Id: {i.Id} Nome: {i.Nome} DataNascimento: {i.DataNascimento.ToString("dd-MM-yyyy")} Carteira: {i.Carteira.ToString("C")}"));

            Console.WriteLine("==========================================================================================");
            Console.WriteLine("MAIOR QUE 18");
            listPessoa.Where(x => (DateTime.Today.Year - 18) >= x.DataNascimento.Year && DateTime.Today.Month >= x.DataNascimento.Month && DateTime.Today.Day >= x.DataNascimento.Day).ToList().ForEach(i => Console.WriteLine($"Id: {i.Id} Nome: {i.Nome} DataNascimento: {i.DataNascimento.ToString("dd-MM-yyyy")}"));

            Console.WriteLine("==========================================================================================");
            Console.WriteLine("MENOR QUE 16");
            listPessoa.Where(x => DateTime.Today.Year - x.DataNascimento.Year <= 16).ToList().ForEach(i => Console.WriteLine($"Id: {i.Id} Nome: {i.Nome} DataNascimento: {i.DataNascimento.ToString("dd-MM-yyyy")}"));

            Console.ReadKey();
        }
    }
}
