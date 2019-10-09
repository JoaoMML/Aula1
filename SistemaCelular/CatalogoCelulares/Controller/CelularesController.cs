using CatalogoCelulares.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCelulares.Controller
{
    public class CelularesController
    {
        CelularesContextDB contextDb = new CelularesContextDB();

        //Listagem
        public IQueryable<Celular> GetCelulares()
        {
            return contextDb.Celulares.Where(x => x.Ativo == true);
        }

        //Atualizacao
        public bool AtualizaCelular(Celular item)
        {
            var celular = contextDb.Celulares.FirstOrDefault(x => x.Id == item.Id);

            if (celular == null)
                return false;
            else
                celular = item;
            contextDb.SaveChanges();

            return true;
        }

        // Inserção
        public bool InserirCelular(Celular item)
        {
            //Fazemos as validacoes ao contrario pois se algum item não corresponder ao necessário ele já sai sem testar os proximos!
            if (string.IsNullOrWhiteSpace(item.Marca))
                return false;
            if (string.IsNullOrWhiteSpace(item.Modelo))
                return false;
            if (item.Preco <= 0)
                return false;

            // Se passar todos ele adiciona no comando logo abaixo!
            contextDb.Celulares.Add(item);
            contextDb.SaveChanges();
            return true;
        }

        //Remoção (** Deixar inativo! **)
        public bool RemoverCelular(int id)
        {
            var celular = contextDb.Celulares.FirstOrDefault(x => x.Id == id);

            if (celular == null)
                return false;

            celular.Ativo = false;
            contextDb.SaveChanges();

            return true;
        }
    }
}
