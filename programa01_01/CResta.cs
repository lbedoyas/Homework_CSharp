using System;
using System.Collections.Generic;
using System.Text;

namespace programa01_01
{
    public class CResta : IOperacion
    {
        private double r = 0;
        public void calcular(double a, double b)
        {
            r = a - b;
        }

        public void mostrar()
        {
            Console.WriteLine("El resutado de la resta es: {0}", r);
        }
    }
}
