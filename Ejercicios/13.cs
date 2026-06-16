using System;

class Ejercicio14
{
    static void Main()
    {
        try
        {
            Console.Write("Ingresa una frase inicial: ");
            string frase = Console.ReadLine();
            
            if (string.IsNullOrWhiteSpace(frase))
            {
                throw new ArgumentException("La frase no puede estar vacía ni contener solo espacios.");
            }

            Console.WriteLine($"Análisis de la frase");
            Console.WriteLine($"Caracteres totales: {frase.Length}");

            string[] palabras = frase.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"Palabras totales: {palabras.Length}");

            int cantidadVocales = 0;
            string vocales = "aeiouAEIOU";
            foreach (char c in frase)
            {
                if (vocales.Contains(c))
                {
                    cantidadVocales++;
                }
            }
            Console.WriteLine($"Vocales totales: {cantidadVocales}");

            Console.Write("Ingresa una posición para extraer su carácter: ");
            int posicion = int.Parse(Console.ReadLine());
            Console.WriteLine($"Carácter en posición {posicion}: '{frase[posicion]}'");

            Console.Write("Ingresa un número para dividir 100 por él: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"Resultado de 100 / {numero} = {100 / numero}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Se esperaba un formato numérico entero.");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Error: La posición indicada no pertenece al rango del texto.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error matemático: No se puede dividir 100 por cero.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error de argumento: {ex.Message}");
        }
    }
}