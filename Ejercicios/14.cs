using System;

class Ejercicio12
{
    static void Main()
    {
        Console.Write("Por favor, ingresa un texto: ");
        string entrada = Console.ReadLine();

        string textoNulo = null;

        if (!string.IsNullOrEmpty(entrada))
        {
            textoNulo = entrada;
        }

        try
        {
            int longitud = textoNulo.Length;
            Console.WriteLine($"La longitud del texto ingresado es: {longitud}");
        }
        catch (NullReferenceException)
        {
            Console.WriteLine("Se detectó que no ingresaste nada.");
        }
    }
}