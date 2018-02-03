using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ulatina.Gato.BL.Tests
{
    [TestClass]
    public class BuscarGanador
    {
        [TestMethod]
        public void GanadorEnTresElementos ()
        {
            // primera parte:  definir escenario a probar
            //Ulatina.Gato.BL.Dominio.Validaciones.HayGanador laValidacion = new Ulatina.Gato.BL.Dominio.Validaciones.HayGanador();
            var laValidacion = new Dominio.Validaciones.HayGanador();
            var elResultadoEsperado = true;
            var elResultadoActual = false;
            var laCantidadDeElementos = 3;
            // llene el vector con los valores definidos para la prueba;
            int[] elVector = new int[8] { 3, 5, 5, 3, 5, 3, 3, 3 };

            // segunda parte:  invocar al método que se desea probar
            elResultadoActual = laValidacion.ExisteGanador(elVector, laCantidadDeElementos);

            // tercera parte:  verificar si el resultado es el esperado
            Assert.AreEqual(elResultadoEsperado, elResultadoActual);
            //Assert.IsTrue(elResultadoActual);  
        }

        [TestMethod]
        public void GanadorEnVectorCompleto()
        {
            // primera parte:  definir escenario a probar
            //Ulatina.Gato.BL.Dominio.Validaciones.HayGanador laValidacion = new Ulatina.Gato.BL.Dominio.Validaciones.HayGanador();
            var laValidacion = new Dominio.Validaciones.HayGanador();
            var elResultadoEsperado = true;
            var elResultadoActual = false;
            var laCantidadDeElementos = 8;
            // llene el vector con los valores definidos para la prueba;
            int[] elVector = new int[8] { 3, 3, 3, 3, 3, 3, 3, 3 };

            // segunda parte:  invocar al método que se desea probar
            elResultadoActual = laValidacion.ExisteGanador(elVector, laCantidadDeElementos);

            // tercera parte:  verificar si el resultado es el esperado
            Assert.AreEqual(elResultadoEsperado, elResultadoActual);
            //Assert.IsTrue(elResultadoActual);        
        }

        [TestMethod]
        public void NoHayGanadorEnTresElementos()
        {
            // primera parte:  definir escenario a probar
            //Ulatina.Gato.BL.Dominio.Validaciones.HayGanador laValidacion = new Ulatina.Gato.BL.Dominio.Validaciones.HayGanador();
            var laValidacion = new Dominio.Validaciones.HayGanador();
            var elResultadoEsperado = false;
            var elResultadoActual = true;
            var laCantidadDeElementos = 3;
            // llene el vector con los valores definidos para la prueba;
            int[] elVector = new int[8] { 3, 5, 5, 3, 5, 3, 3, 0 };

            // segunda parte:  invocar al método que se desea probar
            elResultadoActual = laValidacion.ExisteGanador(elVector, laCantidadDeElementos);

            // tercera parte:  verificar si el resultado es el esperado
            //Assert.AreEqual(elResultadoEsperado, elResultadoActual);
            Assert.IsFalse(elResultadoActual);  
        }
    }
}
