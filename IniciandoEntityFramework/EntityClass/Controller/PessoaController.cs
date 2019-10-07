using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Colocamos o using da pasta Model
using EntityClass.Model;

namespace EntityClass.Controller
{
    //Definimos a class como public
    public class PessoaController
    {
        //Inicializamos o EntituContextDB
        EntityContextDB contextDb = new EntityContextDB();

        public IQueryable<Pessoa> GetPessoas()
        {
            return contextDb.ListaDePessoas;
        }

        public void AddPessoa(Pessoa item)
        {
            contextDb.ListaDePessoas.Add(item);
            contextDb.SaveChanges();
        }
    }
}
