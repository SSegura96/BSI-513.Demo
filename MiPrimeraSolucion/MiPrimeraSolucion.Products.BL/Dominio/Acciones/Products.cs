using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiPrimeraSolucion.Products.BL.Dominio.Acciones
{
    public class Products
    {
        public IList<Model.Product> ListarProductosPorColor(string elColor)
        {
            var elRepositorio = new Dominio.Repositorios.Products();
            return elRepositorio.ListarProductosPorColor(elColor);
        }
    }
}