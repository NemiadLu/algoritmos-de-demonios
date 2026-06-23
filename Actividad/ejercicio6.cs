using System;

namespace Ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vectorMayor = new int[8];

            for (int i = 0; i < vectorMayor.Length; i++)
            {
                Console.Write($"Ingrese el número para la posición {i}: ");
                vectorMayor[i] = Convert.ToInt32(Console.ReadLine());
            }

            int numeroMayor = vectorMayor[0];
            int indiceMayor = 0;

            for (int i = 1; i < vectorMayor.Length; i++)
            {
                if (vectorMayor[i] > numeroMayor)
                {
                    numeroMayor = vectorMayor[i];
                    indiceMayor = i;
                }
            }

            Console.WriteLine($"El número más grande es {numeroMayor} y se encuentra en el índice {indiceMayor}.");
        }
    }
}