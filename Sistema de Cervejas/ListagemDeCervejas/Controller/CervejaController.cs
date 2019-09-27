using ListagemDeCervejas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCervejas.Controller
{
    public class CervejaController
    {
        SistemaCervejaContext sistemaCervejaContext = new SistemaCervejaContext();

        public List<Cerveja> GetCervejas()
        {
            return sistemaCervejaContext.ListaCervejasPublicas;
        }

        public void AddCervejas(Cerveja cerveja)
        {
            cerveja.Id = sistemaCervejaContext.IdContador++;
            sistemaCervejaContext.listCerveja.Add(cerveja);
        }

    }
}
