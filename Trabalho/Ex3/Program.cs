﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCicle
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowInitAppText();
            var nome = AskToName();
            AskToAge(nome);

            EndMensage();
        }
        private static string AskToName()
        {
            Console.WriteLine("Informe o seu nome:");
            return Console.ReadLine();
        }
        private static void AskToAge(string nome)
        {
            Console.WriteLine("\r\n Informe a sua idade: \r\n");
            var idade = int.Parse(Console.ReadLine());
            Console.Clear();
            if (idade >= 18)
                Console.WriteLine($"Parabéns {nome} você já esta na fase adulta.");
            else Console.WriteLine($"Calma {nome} tudo ao seu tempo logo você terá 18 anos de idade.");
        }
        private static void ShowInitAppText()
        {
            Console.WriteLine("============================================");
            Console.WriteLine("========== SEJA BEM VINDO! =================");
            Console.WriteLine("============================================");
        }
        public static void EndMensage()
        {
            Console.WriteLine("Digite qualquer tecla para sair..");
            Console.ReadKey();
        }
    }
}
