using System;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] peliculas = new string[5];

            for (int i = 0; i < peliculas.Length; i++)
            {
                Console.Write($"Ingrese su película favorita {i + 1}: ");
                peliculas[i] = Console.ReadLine();
            }

            Console.WriteLine("\nTus películas favoritas son:");
            foreach (string pelicula in peliculas)
            {
                Console.WriteLine($"- {pelicula}");
            }
        }
    }
}