using ListagemDeCarros.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCarros.Controller
{
    // Chama lista da vida a ela e cria um getCarros para retornar a lista
    public class CarroController
    {
        SistemaCarrosContext sistemaCarrosContext = new SistemaCarrosContext();
        /// <summary>
        /// Metodos que retorna lista de carros
        /// </summary>
        /// <returns>Retorna a lista de carros</returns>
        public List<Carro> GetCarros()
        {
            return sistemaCarrosContext.ListCarros;
        }
    }
}
