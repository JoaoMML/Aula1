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
            ControladorDeFluxo();
            MenuSistema();
            Console.ReadKey();
        }

        /// <summary>
        /// Verifica o usuario e senha e retorna um bollean para usar no ControladorDeFluxo 
        /// </summary>
        /// <returns></returns>
        private static bool ValidaAcesso()
        {
            Console.WriteLine("Login:");
            var login = Console.ReadLine();

            Console.WriteLine("Senha:");
            var senha = Console.ReadLine();

            UsuarioController usuarioController = new UsuarioController();

            return usuarioController.LoginSistema(login, senha);

            //{
            //    Console.Clear();
            //    Console.WriteLine($"Seja bem vindo {login}!");
            //    MenuSistema();
            //}
            //else
            //{
            //    Console.Clear();
            //    Console.WriteLine("O usuario ou senha não existe, tente novamente!");
            //    ValidaAcesso();
            //}


        }

        /// <summary>
        ///Fazendo um controlador de fluxo (Melhor que funções recursivas!);
        /// </summary>
        private static void ControladorDeFluxo()
        {
            while (!ValidaAcesso())
            {
                Console.Clear();
                Console.WriteLine("Login ou senha inválidos!");
            }
        }

        /// <summary>
        /// Menu do sistema
        /// </summary>
        private static void MenuSistema()
        {
            Console.Clear();
            Console.WriteLine("** Escolha a opção desejada **");
            Console.WriteLine("0 - Sair ");
        }

        /// <summary>
        /// Mensagem de Inicialização!
        /// </summary>
        private static void BoasVindas()
        {
            Console.Clear();
            Console.WriteLine("================================");
            Console.WriteLine("SISTEMA DE LOCAÇÃO DE LIVROS");
            Console.WriteLine("================================");
            Console.WriteLine("Para acessar informe seu login e senha!!");
        }
    }
}
