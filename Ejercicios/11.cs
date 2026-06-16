using System;

class Ejercicio13
{
    static void Main()
    {
        try
        {
            Console.Write("Ingresa el primer número entero grande: ");
            int num1 = int.Parse(Console.ReadLine());
            
            Console.Write("Ingresa el segundo número entero grande: ");
            int num2 = int.Parse(Console.ReadLine());

            checked
            {
                int suma = num1 + num2;
                Console.WriteLine($"El resultado de la suma es: {suma}");
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error de desbordamiento: La suma supera el límite máximo de almacenamiento para el tipo Int32.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: La entrada no tiene un formato numérico entero válido.");
        }
    }
}