using System;

namespace Edad
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su edad");
            string linea = Console.ReadLine();
            int edad = int.Parse(linea);

            if (edad < 18)
            {
                Console.WriteLine("Usted todavía no puede votar");
            }
            else
            {
                if (edad >= 70)
                {
                    Console.WriteLine("Usted ya no tiene obligación de votar");
                }
                else
                {
                    Console.WriteLine("Usted tiene la obligación de votar");
                }
            }

            Console.ReadKey();
        }
    }
}