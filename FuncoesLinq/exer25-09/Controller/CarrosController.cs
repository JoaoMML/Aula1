using exer25_09.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer25_09.Controller
{
    public class CarrosController
    {
        SistemaVendasContext sistemaContext = new SistemaVendasContext();

        public List<CarroModel> GetCarros(int mes = 0)
        {
            if (mes == 0)
                return sistemaContext.ListaPublica;
            else
                return sistemaContext.ListaPublica.FindAll(x => x.Ano.Month == mes);
        }
    }
}
