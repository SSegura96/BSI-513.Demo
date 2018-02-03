using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ulatina.Gato.BL.Dominio.Validaciones
{
    public class HayGanador
    {
        public bool ExisteGanador(int[] elVector, int laCantidadDeOcurencias)
        {
            bool elResultado = false;
            int largoVector = elVector.Length;
            int contadorOcurrencias = 0;
            int ocurrenciaAnterior = -1;
            for (int i = 0; (i < largoVector) && (contadorOcurrencias < laCantidadDeOcurencias); i++)
            {
                if (elVector[i] == ocurrenciaAnterior)
                    contadorOcurrencias++;
                else
                {
                    ocurrenciaAnterior = elVector[i];
                    contadorOcurrencias = 1;
                }
            }
            elResultado = contadorOcurrencias == laCantidadDeOcurencias;
            return elResultado;
        }
    }
}