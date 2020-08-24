using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePratico.Classes
{
    public class Calculos
    {
        /// <summary>
        /// Calcula a Quantidade de Pilares e a quantidade de bases reforçadas
        /// </summary>
        /// <param name="distanciaTotal"></param>
        /// <param name="distanciaPilares"></param>
        /// <param name="baseReforcada"></param>
        /// <returns>retorna Array[0]= quantidade de pilares, Array[1]=quantidade de bases reforçadas</returns>
        public int[] CalcularPilar(double distanciaTotal, double distanciaPilares, double baseReforcada)
        {
            int[] results = new int[2];

            int i = 3;
            int reforcoQnt = 2;
            double q = distanciaTotal;
            while (q > distanciaPilares)
            {
                if(q <= baseReforcada )
                {
                    reforcoQnt++;
                }
                q = q / 2;
                i++;
            }

            results[0] = i; //quantidade de pilares           
            results[1] = reforcoQnt; //quantidade de pilares reforçados

            return results;
        }
    }
}
