﻿ using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocacaoBiblioteca.Controller;
using LocacaoBiblioteca.Model;

namespace InterfaceBiblioteca
{
    class Program
    {
        //Instanciados "Carregando para memoria" os controladores..
        static LivrosController listLivros = new LivrosController();
        static UsuarioController listUsuarios = new UsuarioController();
        static void Main(string[] args)
        {
            BoasVindas();
            ControladorDeFluxo();
            var escolhaMenu = int.MinValue;
            while (escolhaMenu != 0)
            {
                switch (MenuSistema())
                {
                    case 1:
                        MostrarUsuarios();
                        break;
                    case 2:
                        MostrarLivros();
                        break;
                    case 3:
                        Console.Clear();
                        ControladorDeFluxo();
                        break;
                    case 4:
                        AdicionaLivro();
                        break;
                    case 5:
                        AdicionaUsuario();
                        break;
                    case 6:
                        RemoveUsuarioPorId();
                        break;
                    case 7:
                        RemoverLivrosPorId();
                        break;
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Até a proxima..");
                        Console.ReadKey();
                        return;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                Console.ReadKey();
            }
        }
        private static void RemoveUsuarioPorId()
        {
            Console.WriteLine("Remover usuario por id");
            MostrarUsuarios();
            Console.WriteLine("Informe o id do usuario que deseja remover..");
            var usuarioId = int.Parse(Console.ReadLine());

            listUsuarios.RemoverUsuario(usuarioId);
        }

        private static void RemoverLivrosPorId()
        {
            Console.WriteLine("Remover livro por id:");
            MostrarLivros();
            Console.WriteLine("Informe o id do livro que deseja remover!");
            var livroId = int.Parse(Console.ReadLine());
            listLivros.RemoverLivros(livroId);
        }
        private static void AdicionaUsuario()
        {
            var senha = string.Empty;
            var repitaSenha = string.Empty;
            Console.Clear();
            Console.WriteLine("Informe o nome de Login:");
            var login = Console.ReadLine();
            Console.WriteLine("Informe a senha:");
            senha = Console.ReadLine();
            Console.WriteLine("Repita a senha:");
            repitaSenha = Console.ReadLine();

            if (listUsuarios.ValidaSenha(senha, repitaSenha))
            {


                listUsuarios.AdicionaUsuario(new Usuario()
                {
                    Login = login,
                    Senha = senha
                });
                Console.WriteLine("Usuario Cadastrado com sucesso!");
            }
            else
            {
                Console.WriteLine("As credenciais não conferem!!");
            }
        }
        private static void AdicionaLivro()
        {
            Console.Clear();
            Console.WriteLine("Informe o nome do livro para cadastrar:");
            var nomeDoLivro = Console.ReadLine();
            listLivros.AdicionarLivro(new Livro()
            {
                Nome = nomeDoLivro
            });
            Console.WriteLine("Livro adicionado com sucesso!");


        }

        private static void MostrarUsuarios()
        {
            Console.Clear();
            Console.WriteLine("\r ********** Lista de usuarios! ****************** \n ");
            listUsuarios.RetornaListaUsuarios().ForEach(i => Console.WriteLine($" Login: {i.Login }\n Senha: {i.Senha} \n ID: {i.Id} \n ----------------------"));
        }

        private static void MostrarLivros()
        {
            Console.Clear();
            Livro livro = new Livro();
            livro.Nome = "Éramos seis";

            // =====================================================
            var unic = new List<Livro>
            {
                new Livro()
                {
                    Nome = "Capitães de Areia",
                },

                new Livro()
                {
                    Nome = "Don Quixote"
                },

                new Livro()
                {
                    Nome = "Vidas Secas"
                }
            };


            Console.WriteLine("************************************* LER DEPOIS ************************************");
            listLivros.RetornaListaLivros().ForEach(i => Console.WriteLine($"ID: {i.Id} = Titulo do livro - {i.Nome}, foi adicionado na biblioteca em {i.DataCriacao.ToString("dd/MMM/yyyy")}"));
            Console.WriteLine("************************************* FIM LISTA  *************************************");
            Console.WriteLine($" \r\n Atualmente estou lendo : { livro.Nome}");
        }

        /// <summary>
        /// Verifica o usuario e senha e retorna um bollean para usar no ControladorDeFluxo 
        /// </summary>
        /// <returns></returns>
        private static bool ValidaALogin()
        {
            Console.WriteLine("Login:");
            var login = Console.ReadLine();

            Console.WriteLine("Senha:");
            var senha = Console.ReadLine();

            return listUsuarios.LoginSistema(new Usuario()
            {
                Login = login,
                Senha = senha
            });

        }

        /// <summary>
        ///Fazendo um controlador de fluxo (Melhor que funções recursivas!);
        /// </summary>
        private static void ControladorDeFluxo()
        {

            while (!ValidaALogin())
            {
                Console.Clear();
                Console.WriteLine("Login ou senha inválidos!");
            }
        }

        /// <summary>
        /// Menu do sistema
        /// </summary>
        private static int MenuSistema()
        {
            Console.Clear();
            Console.WriteLine("** Escolha a opção desejada **");
            Console.WriteLine("1 - Listar Usuarios");
            Console.WriteLine("2 - Livros");
            Console.WriteLine("3 - Trocar Usuário");
            Console.WriteLine("4 - Cadastrar novo livro");
            Console.WriteLine("5 - Cadastrar novo usuario");
            Console.WriteLine("6 - Remover um usuario");
            Console.WriteLine("0 - Sair ");
            return int.Parse(Console.ReadKey(true).KeyChar.ToString());
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
