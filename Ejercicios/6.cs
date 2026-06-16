using System;

class Ejercicio7
{
    static void Main()
    {
        Console.Write("Ingresa una frase: ");
        string frase = Console.ReadLine();
        
        Console.Write("Ingresa la palabra que deseas buscar: ");
        string palabra = Console.ReadLine();
        
        if (frase.Contains(palabra))
        {
            Console.WriteLine($"¡Sí! La palabra '{palabra}' se encuentra dentro de la frase.");
        }
        else
        {
            Console.WriteLine($"No se encontró la palabra '{palabra}' en la frase.");
        }
    }
}