using System;

class Ejercicio6
{
    static void Main()
    {
        try
        {
            Console.Write("Ingresa una palabra: ");
            string palabra = Console.ReadLine();
            
            Console.Write("Ingresa la posición que deseas consultar: ");
            int posicion = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"El carácter en la posición {posicion} es: {palabra[posicion]}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: La posición ingresada debe ser un número entero.");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Error: La posición se encuentra fuera del rango de la palabra.");
        }
    }
}