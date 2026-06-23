using System;

namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] delUnoAlDiez = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] subvector = delUnoAlDiez[3..8];

            Console.WriteLine("Elementos del subvector (índices del 3 al 7 inclusive):");
            foreach (int elemento in subvector)
            {
                Console.Write(elemento + " ");
            }
            Console.WriteLine();
        }
    }
}