using MinhaBiblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessandoBiblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuSistema();
        }
        private static void MenuSistema()
        {
            Console.WriteLine("=================================================");
            Console.WriteLine(" 1 - Calculo area quadrado");
            Console.WriteLine(" 2 - Calculo area triangulo");
            Console.WriteLine(" 3 - Animação");
            Console.WriteLine(" 4 - Sair sistema");
            Console.WriteLine("=================================================");
            var opcao = Console.ReadKey().KeyChar;
            Console.Clear();
            switch (opcao)
            {
                case '1':
                    Console.WriteLine(">> CALCULO AREA DO QUADRADO <<");
                    CalculaAreaQuadrado();
                    MenuSistema();
                    Console.WriteLine("Aperte algo para sair...");
                    Console.Clear();
                    break;
                case '2':
                    Console.WriteLine(">> CALCULO AREA TRIANGULO <<");
                    CalculaAreaTriangulo();
                    MenuSistema();
                    break;
                case '3':
                    Console.WriteLine("Deixe em tela cheia e aperte qualquer coisa!");
                    Console.ReadKey();
                    AnimacaoEmFrames.Executar();
                    break;
                case '4':
                    Console.WriteLine("Beijo na bunda e até a proxima..");
                    Console.ReadKey();
                    return;
                default:
                    break;
            }
        }
        public static void CalculaAreaQuadrado()
        {
            Console.WriteLine("Informe o lado do quadrado:");
            var ladoQuadrado = int.Parse(Console.ReadLine());
            var bibliotecaCalculos = new CalculosDeArea();

            Console.WriteLine($"A area eh: {bibliotecaCalculos.CalculaAreaQuadrado(ladoQuadrado)}");
            Console.ReadKey();
        }
        public static void CalculaAreaTriangulo()
        {
            Console.WriteLine("Informe a base e em seguida a altura do triangulo:");
            var baseTriangulo = int.Parse(Console.ReadLine());
            var alturaTriangulo = int.Parse(Console.ReadLine());
            var bibliotecaCalculos2 = new CalculosDeArea();

            Console.WriteLine($"A area do triangulo eh:{bibliotecaCalculos2.CalculaAreaTriangulo(baseTriangulo, alturaTriangulo)}");
        }
    }
}
