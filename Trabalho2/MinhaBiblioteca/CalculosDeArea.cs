using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca
{
    public class CalculosDeArea
    {
        /// <summary>
        /// Metodo para calcular area do quadrado!
        /// </summary>
        /// <param name="ladoQuadrado">Lado do quadrado com preisão inteira</param>
        /// <returns>Area do quadrado</returns>
        public double CalculaAreaQuadrado(int ladoQuadrado)
        {
            return ladoQuadrado * ladoQuadrado;
        }
        /// <summary>
        /// Calcula area do triangulo
        /// </summary>
        /// <param name="bas"></param>
        /// <param name="altura"></param>
        /// <returns></returns>
        public double CalculaAreaTriangulo(int bas, int altura)
        {
            return (bas * altura) / 2;
        }
    }
}
