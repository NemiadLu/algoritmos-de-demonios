using System;

class Ejercicio3
{
    static void Main()
    {
        Console.Write("Ingresa una frase para contar sus vocales: ");
        string frase = Console.ReadLine();
        int contador = 0;
        string vocales = "aeiouAEIOU";

        foreach (char c in frase)
        {
            if (vocales.Contains(c))
            {
                contador++;
            }
        }

        Console.WriteLine($"La frase contiene {contador} vocales.");
    }
}