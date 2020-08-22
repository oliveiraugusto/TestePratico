using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePratico.Classes
{
    public class Calculos
    {
        public double[] CalcularPilar(double distanciaTotal, double distanciaPilares, double baseReforcada)
        {
            double[] results = new double[2];

            int i = 3;
            double q = distanciaTotal;
            while (q > distanciaPilares)
            {
                q = q / 2;
                i++;
            }
            results[0] = i; //quantidade de pilares

            return results;
        }
    }
}
