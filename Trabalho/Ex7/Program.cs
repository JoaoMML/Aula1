using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um texto:");
            var texto = Console.ReadLine();
            var qntTexto = texto.Length - 1;
            var a = 0;
            var e = 0;
            var i = 0;
            var o = 0;
            var u = 0;

            for (int j = 0; j < qntTexto; j++)
            {
                if (texto[j].ToString() == "a")
                    a++;
                if (texto[j].ToString() == "e")
                    e++;
                if (texto[j].ToString() == "i")
                    i++;
                if (texto[j].ToString() == "o")
                    o++;
                if (texto[j].ToString() == "u")
                    u++;
            }

            Console.WriteLine($"A quantidade de caracteres com valor A eh: {a}");
            Console.WriteLine($"A quantidade de caracteres com valor E eh: {e}");
            Console.WriteLine($"A quantidade de caracteres com valor I eh: {i}");
            Console.WriteLine($"A quantidade de caracteres com valor O eh: {o}");
            Console.WriteLine($"A quantidade de caracteres com valor U eh: {u}");

            Console.WriteLine("Informe qualquer tecla para sair..");
            Console.ReadKey();
        }
    }
}
