using Amigos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amigos
{
    class Program
    {
        static void Main(string[] args)
        {
            var listFriends = new List<Friends>
            {
                new Friends()
                {
                    Nome = "Maicon",
                    TempoAmizade = 1
                },
                new Friends()
                {
                    Nome = "Pedrinho",
                    TempoAmizade = 4
                },
                new Friends()
                {
                    Nome = "Jorge",
                    TempoAmizade = 5
                }
            };
            listFriends.ForEach(i => Console.WriteLine($"{i.Nome} é seu amigo a {i.TempoAmizade} anos.. "));
            Console.ReadLine();
        }
    }
}
