using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCarros.Model
{
    // Criar lista e encher com dados '29'
    public class SistemaCarrosContext
    {
        public List<Carro> ListCarros { get; set; }

        public SistemaCarrosContext()
        {
            ListCarros = new List<Carro>();
            ListCarros.Add(new Carro() { Id = 1, Ano = 2001, Cilindradas = 2000, Marca = "Fiat", Modelo = "Uno da escada foda", Portas = 2 });
        }
    }
}
