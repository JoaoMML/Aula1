using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlunosClass.Model; // Adicionado

namespace AlunosClass.Controller
{
    public class AlunosController
    {
        //Chama o model Context db e inicializa
        EntityDbContext contextoDb = new EntityDbContext();

        public IQueryable<Aluno> GetAlunos()
        {
            return contextoDb.ListAlunos;
        }
        public void AddAluno(Aluno item)
        {
            contextoDb.ListAlunos.Add(item);
            contextoDb.SaveChanges();
        }
    }
}
