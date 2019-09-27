using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCervejas.Model
{
    public class SistemaCervejaContext
    {
        public List<Cerveja> listCerveja = new List<Cerveja>();

        public SistemaCervejaContext()
        {
            //Inicializar a lista

            listCerveja = new List<Cerveja>();

            // Adicionar dados
            listCerveja.Add(new Cerveja()
            {
                Id = 1,
                Nome = "Skol Puro Malte",
                LitrosEmMl = 350,
                PercentAlcoolPerMl = 4.4,
                Valor = 2.50

            });
            listCerveja.Add(new Cerveja()
            {
                Id = 2,
                Nome = "Budweiser",
                LitrosEmMl = 330,
                PercentAlcoolPerMl = 5.0,
                Valor = 4.19
            });
            listCerveja.Add(new Cerveja() { Id = 3, Nome = "Original", LitrosEmMl = 600, PercentAlcoolPerMl = 5, Valor = 5.50 });
            listCerveja.Add(new Cerveja() { Id = 4, Nome = "Corona", LitrosEmMl = 355, PercentAlcoolPerMl = 4.5, Valor = 5 });
            listCerveja.Add(new Cerveja() { Id = 5, Nome = "Estella Artois", LitrosEmMl = 275, PercentAlcoolPerMl = 5.2, Valor = 3 });
        }

        // Propriedade que chama a lista ser filtros
        public List<Cerveja> ListaCervejasPublicas { get { return listCerveja; } }
    }
}
