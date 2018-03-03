using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MiPrimeraSolucion.BL.Tests
{
    [TestClass]
    public class ListarProductos
    {
        [TestMethod]
        public void ListarProductosNegros()
        {
            // preparar el escenario
            var elCliente = new SI.Products.ProductsClient();
            List<Model.Product> miLista = null;
            int cantidadDeProductosActual = 0;
            int cantidadDeProductosEsperada = 100;
            string elColor = "Black";

            // invocar al método
            miLista = elCliente.ListarProductosPorColor(elColor);
            cantidadDeProductosActual = miLista.Count;

            // verificar el resultado
            elCliente.Close();
            Assert.AreEqual(cantidadDeProductosEsperada, cantidadDeProductosActual);
        }
    }
}
