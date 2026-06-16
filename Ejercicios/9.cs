using System;

class Ejercicio10
{
    static void Main()
    {
        Console.Write("Crea una nueva contraseña: ");
        string contrasena = Console.ReadLine();

        try
        {
            bool tieneNumero = false;
            foreach (char c in contrasena)
            {
                if (char.IsDigit(c))
                {
                    tieneNumero = true;
                    break;
                }
            }

            if (contrasena.Length < 8 || !tieneNumero)
            {
                throw new ArgumentException("La contraseña no cumple con los requisitos mínimos (al menos 8 caracteres y un número).");
            }

            Console.WriteLine("¡Contraseña aceptada con éxito!");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Validación fallida: {ex.Message}");
        }
    }
}