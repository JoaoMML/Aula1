using System;
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
            var nome = string.Empty;
            var idade = int.MinValue;

            while (AskToContinue() == 1)
            {
                List<string> Lista = new List<string>();
                nome = AskToName();
                idade = AskToAge();
            }
            Console.WriteLine("\r\n Informe uma tecla para sair..");
            Console.ReadKey();
        }
        /// <summary>
        /// Metodo para perguntar o nome.
        /// </summary>
        /// <returns></returns>
        private static string AskToName()
        {
            Console.WriteLine("Informe o seu nome:");
            return Console.ReadLine();
        }
        /// <summary>
        /// Pergunta a idade do usuario.
        /// </summary>
        /// <returns></returns>
        private static int AskToAge()
        {
            Console.WriteLine("\r\n Informe a sua idade: \r\n");
            var idade = int.Parse(Console.ReadLine());
            Console.Clear();
            if (idade >= 18)
                Console.WriteLine("Parabéns voce jah pode ser preso e beber!");
            else Console.WriteLine("Ainda não pode meu filho, vai tomar todynho!");
            return idade;
        }
        /// <summary>
        /// Pergunta ao usuario se ele deseja continuar no programa
        /// </summary>
        /// <returns></returns>
        private static int AskToContinue()
        {
            Console.WriteLine(" \r\n Vamos conversar? sim (1) não (2)");
            // Usar o int.Parse() - Passar como parametro um texto ou objeto para pegar o valor numerico do mesmo.
            var resposta = int.Parse(Console.ReadKey().KeyChar.ToString());
            return resposta;
        }
        /// <summary>
        /// Metodo para mostrar o texto inicial do sistema alone
        /// </summary>
        private static void ShowInitAppText()
        {
            Console.WriteLine("============================================");
            Console.WriteLine("========== SEJA BEM VINDO! =================");
            Console.WriteLine("============================================");
        }
    }
}
