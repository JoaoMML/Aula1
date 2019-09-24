using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Controller
{
    public class UsuarioController
    {
        private int idContador = 0;
        public UsuarioController()
        {
            
        }

        private List<Usuario> ListaUsuario { get; set; }
        /// <summary>
        /// Metodo que realiza o login dentro do nosso sistema
        /// Para realizar o login padrão use:
        /// - Login: Admin
        /// - Senha Admin
        /// </summary>
        /// <param name="login">Login do usuário dentro do sistema</param>
        /// <param name="senha">Senha do usuário dentro do sistema</param>
        /// <returns>Retorna verdadeiro se existir um usuario com login e senha</returns>
        public bool LoginSistema(Usuario usuario)
        {
            return ListaUsuario.Exists(i => i.Login == usuario.Login && i.Senha == usuario.Senha);
        }

        public bool ValidaSenha(string senha, string repitaSenha)
        {
            if (senha != repitaSenha)
            {
                return false;
            }
            return true;
        }

        public void AdicionaUsuario(Usuario parametroUsuario)
        {
            parametroUsuario.Id = idContador++;
            ListaUsuario.Add(parametroUsuario);
        }

        public void RemoverUsuario(int identificadorId)
        {
            // Usamos o firstOrDefault para localizar o usuario dentro da lista que tem a seguinte condição ( x.id == id )
            ListaUsuario.FirstOrDefault(x => x.Id == identificadorId).Ativo = false;
            Console.WriteLine("Usuário desativado com sucesso!");
            Console.ReadKey();
        }

        public List<Usuario> RetornaListaUsuarios()
        {
            return ListaUsuario.Where(x => x.Ativo).ToList<Usuario>();
        }
    }
}
