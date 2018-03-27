using MiPrimeraSolucion.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiPrimeraSolucion.Products.DI.DL.Dominio.Acciones
{
    public class Products
    {
        private static AdventureWorks2012Entities _context = new AdventureWorks2012Entities();
        public Products(AdventureWorks2012Entities elContexto)
        {
            _context = elContexto;
        }

        public IList<Model.Product> ListarProductosPorColor(string elColor)
        {
            var elRepositorio = new Dominio.Repositorios.Products(_context);
            return elRepositorio.ListarProductosPorColor(elColor);
        }
    }
}