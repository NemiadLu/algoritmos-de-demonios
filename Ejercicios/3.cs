using System;

class Ejercicio4
{
    static void Main()
    {
        Console.Write("Ingresa una palabra: ");
        string palabra = Console.ReadLine();

        try
        {
            Console.WriteLine($"Primera letra: {palabra[0]}");
            Console.WriteLine($"Última letra: {palabra[palabra.Length - 1]}");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Error: No se puede procesar una cadena vacía.");
        }
    }
}