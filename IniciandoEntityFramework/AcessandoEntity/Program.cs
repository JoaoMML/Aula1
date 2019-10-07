using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// [BaseExercicios] Adicionar referencia e depois colocar os using
using EntityClass.Controller;
using EntityClass.Model;

namespace AcessandoEntity
{
    class Program
    {
        // Iniciando pessoaController 
        static PessoaController pessoa = new PessoaController();
        static void Main(string[] args)
        {
            pessoa.AddPessoa(new Pessoa() { Nome = "Pedrinho" });
            pessoa.GetPessoas().ToList<Pessoa>().ForEach(x => Console.WriteLine($"Nome: {x.Nome}"));
            Console.ReadKey();
        }
    }
}
