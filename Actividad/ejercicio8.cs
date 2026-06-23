using System;

namespace Ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] palabras = new string[5];
            string resultadoConcatenado = "";

            for (int i = 0; i < palabras.Length; i++)
            {
                Console.Write($"Ingrese la palabra {i + 1}: ");
                palabras[i] = Console.ReadLine();
            }

            foreach (string palabra in palabras)
            {
                if (palabra.Length > 4)
                {
                    resultadoConcatenado += palabra + " ";
                }
            }

            Console.WriteLine($"Resultado de la concatenación: {resultadoConcatenado.Trim()}");
        }
    }
}