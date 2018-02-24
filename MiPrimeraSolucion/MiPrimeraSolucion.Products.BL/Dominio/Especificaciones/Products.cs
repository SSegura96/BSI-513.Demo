using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiPrimeraSolucion.Products.BL.Dominio.Especificaciones
{
    public class Products
    {
        public IList<Model.Product> ListarProductosPorColor(string elColor)
        {
                var laAccion = new Dominio.Acciones.Products();
                return laAccion.ListarProductosPorColor(elColor);
        }

    }
}