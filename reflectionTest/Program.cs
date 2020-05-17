using System;
using System.Linq;
using System.Reflection;

namespace reflectionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reflection es la manera de leer el assembly!");

            try
            {
                int i = 42;
                //string i = "luis";
                Type type = i.GetType();
                Console.WriteLine(type);
                //Type t = Type.GetType("System.Linq");
                //Console.WriteLine(t);
                EncuentraCampos(type);
                Console.WriteLine("------------");
                CaracteristicasTipo(type);
                Console.WriteLine("-------------");
                EncuentraPropiedades(type);
                Console.WriteLine("--------------");
                EncuentraMetodos(type);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("verificar el tipo");
                Console.WriteLine(ex);
            }           
        }

        public static void CaracteristicasTipo(Type t)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("las caracteristicas que tiene son: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("las clase base:  {0}", t.BaseType);
            Console.WriteLine("Es una clase: {0}", t.IsClass);
            Console.WriteLine("Abstracta: {0}", t.IsAbstract);
            Console.WriteLine("sellada: {0}", t.IsSealed);
            Console.WriteLine("generica: {0}", t.IsGenericTypeDefinition);
        }

        public static void EncuentraCampos(Type t)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Los campos encontrados son: ");
            Console.ForegroundColor = ConsoleColor.White;

            //Encontramos los campos en ese tipo
            var nombres = from f in t.GetFields() select f.Name;
            foreach (var item in nombres)
            {
                Console.WriteLine("{0}", item);
            }
        }


        public static void EncuentraPropiedades(Type t)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Las propiedades encontrados son: ");
            Console.ForegroundColor = ConsoleColor.White;
            var nombres = from f in t.GetProperties() select f.Name;
            foreach (var item in nombres)
            {
                Console.WriteLine("{0}", item);
            }
        }

        public static void EncuentraMetodos(Type t)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Las metodos encontrados son: ");
            Console.ForegroundColor = ConsoleColor.White;
            var nombres = from f in t.GetMethods() select f.Name;
            foreach (var item in nombres)
            {
                Console.WriteLine("{0}", item);
            }
        }


    }
}
