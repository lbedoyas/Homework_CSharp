using System;


namespace programa01_01
{
    class Program
    {
        static void Main(string[] args)
        {
            CSuma suma = new CSuma();
            suma.calcular(5, 5);
            suma.mostrar();

            string valor = "";
            int opcion = 0;
            double valA = 0.0;
            double valB = 0.0;

            IOperacion operacion = new CSuma();

            while(opcion != 5)
            {
                Console.WriteLine("1-suma, 2-resta, 3-multiplicacion, 4-div, 5-salir");
                Console.WriteLine("Que deseas hacer? ....");
                valor = Console.ReadLine();
                opcion = Convert.ToInt32(valor);

                Console.WriteLine("Dame el valor de A");
                valor = Console.ReadLine();
                valA = Convert.ToDouble(valor);

                Console.WriteLine("Dame el valor de B");
                valor = Console.ReadLine();
                valB = Convert.ToDouble(valor);

                //Poliformismo
                if (opcion == 1)
                {
                    operacion = new CSuma();
                }
                if (opcion == 2)
                {
                    operacion = new CResta();
                }
                if (opcion == 3)
                {
                    operacion = new CMultiplicacion();
                }
                if (opcion == 4)
                {
                    operacion = new CDivision();
                }

                operacion.calcular(valA, valB);
                operacion.mostrar();

            }

        }
    }
}
