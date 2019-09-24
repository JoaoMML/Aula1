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
        private int idContador = 0;
        public LivrosController()
        {
            ListLivros = new List<Livro>
            {
                new Livro()
                {   Id = idContador++,
                    Nome = "Capitães de Areia",
                },

                new Livro()
                {
                    Id = idContador++,
                    Nome = "Don Quixote"
                },

                new Livro()
                {
                    Id = idContador++,
                    Nome = "Vidas Secas"
                }
            };

        }
        private List<Livro> ListLivros { get; set; }

        /// <summary>
        /// Metodo que adiciona o livro em nossa lista já "instanciada"
        /// </summary>
        /// <param name="parametroLivro"></param>
        public void AdicionarLivro(Livro parametroLivro)
        {
            parametroLivro.Id = idContador++;
            ListLivros.Add(parametroLivro);
        }

        public void RemoverLivros(int identificadorId)
        {
            ListLivros.FirstOrDefault(x => x.Id == identificadorId).Ativo = false;
            Console.WriteLine("Livro removido com sucesso!");
            Console.ReadKey();
        }

        public List<Livro> RetornaListaLivros()
        {
            return ListLivros.Where(x => x.Ativo == true).ToList<Livro>();
        }
    }
}
