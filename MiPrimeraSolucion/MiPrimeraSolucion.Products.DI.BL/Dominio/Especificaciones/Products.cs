using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MiPrimeraSolucion.Model;

namespace MiPrimeraSolucion.Products.DI.BL.Dominio.Especificaciones
{
    public class Products
    {
        private static string _connectionString;

        public Products(string connectionString)
        {
            _connectionString = connectionString;
        }
        public IList<Model.Product> ListarProductosPorColor(string elColor)
        {
                var laAccion = new Dominio.Acciones.Products(_connectionString);
                return laAccion.ListarProductosPorColor(elColor);
        }

    }
}