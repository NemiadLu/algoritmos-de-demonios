using System;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] notas = new double[5];
            double suma = 0;

            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write($"Ingrese la nota {i + 1}: ");
                notas[i] = Convert.ToDouble(Console.ReadLine());
                suma += notas[i];
            }

            double promedio = suma / notas.Length;
            Console.WriteLine($"Suma total: {suma} | Promedio: {promedio:F2}");

            if (promedio >= 6) Console.WriteLine("Estado: Aprobado");
            else Console.WriteLine("Estado: Reprobado");
        }
    }
}