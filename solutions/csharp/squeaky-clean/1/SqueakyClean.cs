using System;
using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        if (string.IsNullOrEmpty(identifier)) return string.Empty;

        var sb = new StringBuilder();
        bool uppercaseNext = false;

        for (int i = 0; i < identifier.Length; i++)
        {
            char current = identifier[i];

            // 1. Reemplazar espacios por guiones bajos
            if (current == ' ')
            {
                sb.Append('_');
            }
            // 2. Reemplazar caracteres de control por "CTRL"
            else if (char.IsControl(current))
            {
                sb.Append("CTRL");
            }
            // 3. Preparar la conversión de kebab-case (marcar la siguiente letra para mayúscula)
            else if (current == '-')
            {
                uppercaseNext = true;
            }
            // 4. Filtrar letras griegas minúsculas (rango α a ω)
            else if (current >= '\u03b1' && current <= '\u03c9')
            {
                // Se ignoran por completo
            }
            // 5. Procesar letras válidas
            else if (char.IsLetter(current))
            {
                if (uppercaseNext)
                {
                    sb.Append(char.ToUpper(current));
                    uppercaseNext = false; // Resetear la bandera
                }
                else
                {
                    sb.Append(current);
                }
            }
            // Cualquier otro carácter (números, símbolos especiales) se descarta automáticamente
        }

        return sb.ToString();
    }
}