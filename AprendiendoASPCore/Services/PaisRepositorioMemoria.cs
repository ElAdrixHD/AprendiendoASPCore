using AprendiendoASPCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AprendiendoASPCore.Services
{
    public class PaisRepositorioMemoria : IRepositorioPais
    {
        public List<Pais> ObtenerTodos()
        {
            List<Pais> paises = new List<Pais>()
            { new Pais("España"),new Pais("Francia"),new Pais("Alemania"),new Pais("Inglaterra"),new Pais("Suiza")
            };
            return paises;
        }
    }
}
