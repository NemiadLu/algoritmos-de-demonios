using System;

class Ejercicio2
{
    static void Main()
    {
        Console.Write("Ingresa una palabra: ");
        string palabra = Console.ReadLine();
        
        Console.WriteLine($"En mayúsculas: {palabra.ToUpper()}");
        Console.WriteLine($"En minúsculas: {palabra.ToLower()}");
        Console.WriteLine($"Total de caracteres: {palabra.Length}");
    }
}