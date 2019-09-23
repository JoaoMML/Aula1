using CestaDeFrutas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CestaDeFrutas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Preenchendo a lista
            var cestaFruta = new List<Fruta>
            {
                new Fruta() { Id = 0 , Nome = "Morango",Cor = "vermelho",Peso = 20},

                new Fruta(){ Id = 1, Nome = "Melancia", Cor ="Verde",Peso=1500},

                new Fruta(){ Id = 2, Nome = "Banana", Cor ="Amarela",Peso=50},
            };

            #region FILTROS DE LISTAS TIPO SQL
            // FILTROS DE LISTA E ORDENAÇÃO

            Console.WriteLine("\n ------------- ORDER BY NOME DESC ---------- \n \n ");
            // Order by Nome Desc                ↓↓↓     Imprimindo agora ↓↓↓
            cestaFruta.OrderByDescending(x => x.Nome).ToList<Fruta>().ForEach(i => Console.WriteLine($"Id ={i.Id} / Nome: {i.Nome}/ Peso ={i.Peso}"));

            // Lista com Where
            Console.WriteLine("\n ------------ Filtro peso > 100 ------------- \n \n");
            var filtroCesta = cestaFruta.Where(x => x.Peso >= 30).OrderBy(x => x.Nome);
            filtroCesta.ToList<Fruta>().ForEach(i => Console.WriteLine($"Id = {i.Id} / Nome = {i.Nome} / Peso = {i.Peso}"));

            Console.WriteLine("\n ------------ Filtro Nome diferente Banana ------------ \n \n");
            // Select em uma lista
            (from registroLista in cestaFruta where registroLista.Nome != "Banana" select registroLista).ToList<Fruta>().ForEach(i => Console.WriteLine($"Fruta escolhida: {i.Nome}"));
            #endregion

            Console.ReadKey();

        }
    }
}
