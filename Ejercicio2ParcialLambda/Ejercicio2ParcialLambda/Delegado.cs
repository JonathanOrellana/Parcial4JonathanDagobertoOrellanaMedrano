using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2ParcialLambda
{
    delegate double total(double a);
    class Delegado
    {
        public double desc(double a)
        {
            double resultado = 0;
            if (a > 10000 & a < 20000)
            {
                resultado = a * 0.10;

            }
            if (a > 20001 & a < 50000)
            {
                    resultado = a * 0.30;

            }
            if (a > 50000)
            {
                resultado = a * 0.50;

            }
            return resultado ;
        }
        
    }
}
