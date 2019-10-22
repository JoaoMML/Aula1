using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlorLibrary.Model;

namespace FlorLibrary.Controller
{
    public class FlorController
    {
        FlorContext contextDb = new FlorContext();

        public IQueryable<Flor> GetFlores()
        {
            return contextDb.Flores.Where(x => x.Ativo == true);
        }

        //Atualizacao
        public bool Atualiza(Flor item)
        {
            var celular = contextDb.Flores.FirstOrDefault(x => x.Id == item.Id);

            if (celular == null)
                return false;
            else
                celular = item;
            contextDb.SaveChanges();

            return true;
        }

        // Inserção
        public bool Inserir(Flor item)
        {
            //Fazemos as validacoes ao contrario pois se algum item não corresponder ao necessário ele já sai sem testar os proximos!
            if (string.IsNullOrWhiteSpace(item.Nome))
                return false;
            if (item.Quantidade < 0)
                return false;
            // Se passar todos ele adiciona no comando logo abaixo!
            contextDb.Flores.Add(item);
            contextDb.SaveChanges();
            return true;
        }

        //Remoção (** Deixar inativo! **)
        public bool Remover(int id)
        {
            var celular = contextDb.Flores.FirstOrDefault(x => x.Id == id);

            if (celular == null)
                return false;

            celular.Ativo = false;
            contextDb.SaveChanges();

            return true;
        }
    }
}
