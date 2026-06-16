using System;

class Ejercicio9
{
    static void Main()
    {
        Console.Write("Ingresa una palabra para invertir: ");
        string palabra = Console.ReadLine();
        
        char[] caracteres = palabra.ToCharArray();
        Array.Reverse(caracteres);
        
        Console.WriteLine($"Palabra invertida: {new string(caracteres)}");
    }
}