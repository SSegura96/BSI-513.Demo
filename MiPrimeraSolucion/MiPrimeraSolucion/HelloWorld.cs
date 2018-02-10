using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MiPrimeraSolucion
{
    [TestClass]
    public class HelloWorld
    {
        string resultadoActual;
        string resultadoEsperado;
        MiPrimeraSolucion.BL.PruebaBL elMetodo = new MiPrimeraSolucion.BL.PruebaBL();

        [TestMethod]
        public void SayHelloEmpty()
        {
            // preparar el escenario
            resultadoEsperado = "Hello!";
            // ejecutar la prueba
            resultadoActual = elMetodo.SayHello();

            // evaluar el resultado obtenido
            Assert.AreEqual(resultadoEsperado, resultadoActual);
        }

        [TestMethod]
        public void SayHelloToEsme()
        {
            // preparar el escenario
            resultadoEsperado = "Hello Esme!";
            string someoneSName = "Esme";

            // ejecutar la prueba
            resultadoActual = elMetodo.SayHelloToSomeone(someoneSName);

            // evaluar el resultado obtenido
            Assert.AreEqual(resultadoEsperado, resultadoActual);
        }

        [TestMethod]
        public void SayHelloToEmpty()
        {
            // preparar el escenario
            resultadoEsperado = "Hello!";
            string someoneSName = string.Empty;

            // ejecutar la prueba
            resultadoActual = elMetodo.SayHelloToSomeone(someoneSName);

            // evaluar el resultado obtenido
            Assert.AreEqual(resultadoEsperado, resultadoActual);
        }

    }
}
