using System;

namespace NuevoProyectoViernes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = new string[2];
            string[] apellidos = new string[2];

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine("Ingrese nombre");
                nombres[i] = Console.ReadLine();

                Console.WriteLine("Ingrese apellido");
                apellidos[i] = Console.ReadLine();

            }



            Console.Clear();

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine(nombres[i]);
                Console.WriteLine(apellidos[i]);
                Console.WriteLine();
            }

        }
    }
}
