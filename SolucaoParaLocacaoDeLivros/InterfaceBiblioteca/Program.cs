using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocacaoBiblioteca.Controller;

namespace InterfaceBiblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            BoasVindas();
            ValidaAcesso();
            Console.ReadKey();
        }

        private static void BoasVindas()
        {
            Console.Clear();
            Console.WriteLine("================================");
            Console.WriteLine("SISTEMA DE LOCAÇÃO DE LIVROS");
            Console.WriteLine("================================");
            Console.WriteLine("Para acessar informe seu login e senha!!");
        }
        private static void ValidaAcesso()
        {
            Console.WriteLine("Login:");
            var login = Console.ReadLine();

            Console.WriteLine("Senha:");
            var senha = Console.ReadLine();

            UsuarioController usuarioController = new UsuarioController();

            if (usuarioController.LoginSistema(login, senha))
            {
                Console.Clear();
                Console.WriteLine($"Seja bem vindo {login}!");
                MenuSistema();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("O usuario ou senha não existe, tente novamente!");
                ValidaAcesso();
            }
        }
        private static void MenuSistema()
        {
            Console.WriteLine("** Escolha a opção desejada **");
            Console.WriteLine("0 - Sair ");
        }
    }
}
