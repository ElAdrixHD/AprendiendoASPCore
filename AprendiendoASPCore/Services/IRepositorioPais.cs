using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AprendiendoASPCore.Models;

namespace AprendiendoASPCore.Services
{
    public interface IRepositorioPais
    {
        List<Pais> ObtenerTodos();
    }
}
