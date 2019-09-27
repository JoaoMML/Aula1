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

        public void AddCervejas(string nome, int litrosEmMl, double percenteAlcool, double valor)
        {
            sistemaCervejaContext.listCerveja.Add(new Cerveja() { Id = 10, Nome = nome, LitrosEmMl = litrosEmMl, PercentAlcoolPerMl = percenteAlcool, Valor = valor });
        }

    }
}
