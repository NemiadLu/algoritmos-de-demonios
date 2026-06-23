using System;

namespace Ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vectorMenu = new int[5];

            Console.WriteLine("1. Cargando el vector");
            for (int i = 0; i < vectorMenu.Length; i++)
            {
                Console.Write($"Ingrese valor para posición {i}: ");
                vectorMenu[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\n 2. Mostrando el vector");
            Console.WriteLine("Elementos del vector: " + string.Join(", ", vectorMenu));

            Console.WriteLine("\n 3. Buscando un número ");
            Console.Write("Ingrese el número que desea buscar: ");
            int nBuscar = Convert.ToInt32(Console.ReadLine());
            int idxEncontrado = -1;

            for (int i = 0; i < vectorMenu.Length; i++)
            {
                if (vectorMenu[i] == nBuscar)
                {
                    idxEncontrado = i;
                    break;
                }
            }

            if (idxEncontrado != -1) Console.WriteLine($"El número {nBuscar} está en el índice {idxEncontrado}.");
            else Console.WriteLine("Número no encontrado en el vector.");

            Console.WriteLine("\n 4. Sumando todos los elementos");
            int sumaTotal = 0;
            foreach (int elemento in vectorMenu)
            {
                sumaTotal += elemento;
            }
            Console.WriteLine($"La suma de todos los elementos es: {sumaTotal}");
        }
    }
}