using System;
using System.Collections.Generic;
using System.Text;

namespace Sesion1
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Entramos en el coche");

            Coche coche = new Coche();

            coche.Iniciar();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Avanzamos " + (i+1) + "m.");
            }

            coche.Apagar();

            Console.WriteLine("Salimos del coche");

        }
    }
}
