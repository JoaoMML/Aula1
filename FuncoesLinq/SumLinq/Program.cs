using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            SomaBalasListCriancas();
        }

        private static void SomarInterirosPositivos()
        {
            // Usar [] em itens "primitivos" podemos criar uma coleção destes valores
            int[] colecaoInteiros = new int[5] { 1, 2, 3, 4, 5 };

            Console.WriteLine(colecaoInteiros.Sum());
            Console.ReadKey();
        }
        private static void SomaInteirosList()
        {
            var listaInteiros = new List<int>(){
                1,2,3,4,5
            };

            Console.WriteLine(listaInteiros.Sum()); ;
            Console.ReadKey();
        }
        private static void SomaBalasListCriancas()
        {
            List<Crianca> criancasList = new List<Crianca>() {
                new Crianca(){
                    Nome = "Juninho",
                    QntBalas = 9
                },
                new Crianca(){
                    Nome = "Mariazinha",
                    QntBalas = 68
                }
            };
            Console.WriteLine($"A quantidade total de balas eh:{ criancasList.Sum(i => i.QntBalas)}");
            Console.ReadLine();
        }
    }
}
