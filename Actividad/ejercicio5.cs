using System;

namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] colores = { "Rojo", "Verde", "Azul", "Amarillo", "Negro" };
            Console.WriteLine("Colores disponibles:");
            for (int i = 0; i < colores.Length; i++)
            {
                Console.WriteLine($"[{i}]: {colores[i]}");
            }
            Console.Write("Ingrese el índice a eliminar (0 a 4): ");
            int indiceEliminar = Convert.ToInt32(Console.ReadLine());

            if (indiceEliminar >= 0 && indiceEliminar < colores.Length)
            {
                for (int i = indiceEliminar; i < colores.Length - 1; i++)
                {
                    colores[i] = colores[i + 1];
                }
                colores[colores.Length - 1] = "";

                Console.WriteLine("Arreglo actualizado:");
                foreach (var color in colores)
                {
                    Console.WriteLine($"[{color}]");
                }
            }
            else
            {
                Console.WriteLine("Índice fuera de rango.");
            }
        }
    }
}