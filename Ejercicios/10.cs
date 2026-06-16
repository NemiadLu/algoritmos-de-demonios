using System;

class Ejercicio11
{
    static void Main()
    {
        try
        {
            Console.Write("Ingresa tu edad: ");
            int edad = int.Parse(Console.ReadLine());

            if (edad < 1 || edad > 120)
            {
                throw new ArgumentOutOfRangeException("edad", "La edad debe encontrarse en un rango real de 1 a 120 años.");
            }

            Console.WriteLine($"Edad registrada correctamente: {edad} años.");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Error de rango: {ex.Message}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Debes introducir un valor numérico entero.");
        }
    }
}