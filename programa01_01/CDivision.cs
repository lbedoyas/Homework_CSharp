using System;
using System.Collections.Generic;
using System.Text;

namespace programa01_01
{
    class CDivision : IOperacion
    {
        private double r = 0;
        public void calcular(double a, double b)
        {
            r = a + b;
        }

        public void mostrar()
        {
            Console.WriteLine("El resultado de la division es: {0}", r);
        }
    }
}
