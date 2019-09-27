using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCervejas.Model
{
    public class Cerveja
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int LitrosEmMl { get; set; }
        public double PercentAlcoolPerMl { get; set; }
        public double Valor { get; set; }
    }
}
