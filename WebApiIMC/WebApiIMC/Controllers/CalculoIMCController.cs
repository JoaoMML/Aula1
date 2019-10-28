using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebApiIMC.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CalculoIMCController : ApiController
    {
        public string Get()
        {
            //Informo que minha api esta rodando normalmente
            return "Olá você está conectado na WebApi";
        }

        [HttpGet]
        public string Get(double peso,double altura,string nome)
        {
            var imc = peso / (altura * altura);
            return $"Olá,{ nome} seu IMC é { imc.ToString("N2")} e ele foi calculado de acordo com sua Altura: { altura} e Peso:{ peso}";
        }
    }
}
