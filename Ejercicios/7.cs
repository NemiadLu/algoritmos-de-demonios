using System;

class Ejercicio8
{
    static void Main()
    {
        Console.Write("Ingresa números separados por comas (ej. 10,20,30): ");
        string entrada = Console.ReadLine();
        string[] numeros = entrada.Split(',');
        int suma = 0;

        try
        {
            foreach (string num in numeros)
            {
                suma += int.Parse(num.Trim());
            }
            Console.WriteLine($"La suma total de los números es: {suma}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Asegúrate de ingresar únicamente números separados por comas.");
        }
    }
}