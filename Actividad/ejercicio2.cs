using System;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ciudades = { "Madrid", "Buenos Aires", "Bogotá", "Lima", "Santiago" };
            Console.Write("Ingrese la ciudad a buscar: ");
            string buscar = Console.ReadLine();

            int indiceEncontrado = -1;
            for (int i = 0; i < ciudades.Length; i++)
            {
                if (ciudades[i].Equals(buscar, StringComparison.OrdinalIgnoreCase))
                {
                    indiceEncontrado = i;
                    break;
                }
            }

            if (indiceEncontrado != -1)
            {
                Console.WriteLine($"¡Ciudad encontrada! Está en la posición (índice): {indiceEncontrado}");
            }
            else
            {
                Console.WriteLine("Ciudad no encontrada.");
            }
        }
    }
}