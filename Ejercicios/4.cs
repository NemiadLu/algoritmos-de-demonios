using System;

class Ejercicio5
{
    static void Main()
    {
        try
        {
            Console.Write("Ingresa el primer número entero (dividendo): ");
            int num1 = int.Parse(Console.ReadLine());
            
            Console.Write("Ingresa el segundo número entero (divisor): ");
            int num2 = int.Parse(Console.ReadLine());
            
            int resultado = num1 / num2;
            Console.WriteLine($"Resultado de la división: {resultado}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error de formato: Debes ingresar números enteros válidos.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error matemático: No está permitida la división por cero.");
        }
    }
}