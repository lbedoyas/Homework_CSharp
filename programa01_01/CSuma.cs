using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace programa01_01
{
    public class CSuma : IOperacion
    {
        private double r = 0;
        private ArrayList resultados = new ArrayList();
        public void calcular(double a, double b)
        {
            r = a + b;
        }

        public void mostrar()
        {
            Console.WriteLine("el resultado de la suma es: {0}", r);
            resultados.Add(r);
        }

        //metodo propio
        public void mostrarResultados()
        {
            foreach (double r in resultados)
                Console.WriteLine(r);
        }
    }
}
