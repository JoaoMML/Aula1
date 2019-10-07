using AlunosClass.Controller;
using AlunosClass.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessandoAlunos
{
    class Program
    {
        static void Main(string[] args)
        {
            var alunos = new AlunosController();

            var resp = int.MinValue;
            while (resp != 0)
            {
                switch (resp)
                {
                    case 1:
                        Console.WriteLine("Informe o nome da criatura para adicionar na lista!");
                        alunos.AddAluno(new Aluno()
                        {
                            Nome = Console.ReadLine().ToString()
                        });
                        break;
                    default:
                        break;
                }
                
                Console.WriteLine("Deseja adicionar mais um ?");
                Console.WriteLine("Digite 1 para sim e 0 para não!");
                resp = int.Parse(Console.ReadLine());
            }

            alunos.GetAlunos().ToList<Aluno>().ForEach(x => Console.WriteLine(x.Nome));
            Console.WriteLine("Digite algo para sair..");
            Console.ReadKey();

        }

        private static int Menu()
        {
            var op = int.MinValue;
            Console.WriteLine("_+_+_+_+_+_+_+_+_+ Seja bem-vindo _+_+_+_+_+_+_+_+_");
            Console.WriteLine("1 - Para adicionar pessoas a lista");
            Console.WriteLine("2 - Para ver lista");
            Console.WriteLine("=====================================================");
            return op = int.Parse(Console.ReadLine());
        }
    }
}
