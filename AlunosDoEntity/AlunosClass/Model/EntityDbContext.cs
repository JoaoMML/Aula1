using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlunosClass.Model
{
    public class EntityDbContext : DbContext
    {
        public DbSet<Aluno> ListAlunos { get; set; }
    }
}
