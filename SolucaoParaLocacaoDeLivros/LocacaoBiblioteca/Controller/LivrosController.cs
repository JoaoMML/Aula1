using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Controller
{
    public class LivrosController
    {
        public LivrosController()
        {
            Livros = new List<Livro>
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

        }
        public List<Livro> Livros { get; set; }

        /// <summary>
        /// Metodo que adiciona o livro em nossa lista já "instanciada"
        /// </summary>
        /// <param name="parametroLivro"></param>
        public void AdicionarLivro(Livro parametroLivro)
        {
            Livros.Add(parametroLivro);
        }
    }
}
