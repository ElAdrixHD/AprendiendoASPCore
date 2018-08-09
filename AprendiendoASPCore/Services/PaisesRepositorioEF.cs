using AprendiendoASPCore.Data;
using AprendiendoASPCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AprendiendoASPCore.Services
{
    public class PaisesRepositorioEF : IRepositorioPais
    {
        public PaisesRepositorioEF(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public ApplicationDbContext DbContext { get; }

        public List<Pais> ObtenerTodos()
        {
            return DbContext.Paises.ToList();
        }
    }
}
