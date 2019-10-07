using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass.Model
{
    // Aqui herdamos da class DbContext
    public class EntityContextDB : DbContext
    {
        // DbSet é uma palavra reservad
        public DbSet<Pessoa> ListaDePessoas { get; set; }
    }
}
