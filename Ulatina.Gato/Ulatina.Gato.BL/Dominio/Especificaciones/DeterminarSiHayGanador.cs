using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ulatina.Gato.BL.Dominio.Especificaciones
{
    public class DeterminarSiHayGanador
    {
        public bool BuscarGanador(int[,] laMatriz, int laCantidadDeOcurencias)
        {
            Acciones.DeterminarSiHayGanador laAccion = new Acciones.DeterminarSiHayGanador();
            bool elResultado = laAccion.BuscarGanador(laMatriz, laCantidadDeOcurencias);
            return elResultado;
        }
    }
}