using System;
using System.Collections.Generic;

public static class DialingCodes
{
    // TASK 1: Devuelve un diccionario vacío
    public static Dictionary<int, string> GetEmptyDictionary()
    {
        return new Dictionary<int, string>();
    }

    // TASK 2: Devuelve un diccionario pre-poblado con los 3 países iniciales
    public static Dictionary<int, string> GetExistingDictionary()
    {
        return new Dictionary<int, string>
        {
            { 1, "United States of America" },
            { 55, "Brazil" },
            { 91, "India" }
        };
    }

    // TASK 3: Crea un diccionario vacío y añade un código de país
    public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName)
    {
        var dict = new Dictionary<int, string>();
        dict.Add(countryCode, countryName);
        return dict;
    }

    // TASK 4: Añade un país a un diccionario existente
    public static Dictionary<int, string> AddCountryToExistingDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        existingDictionary.Add(countryCode, countryName);
        return existingDictionary;
    }

    // TASK 5: Devuelve el nombre del país o un texto vacío si el código no existe
    public static string GetCountryNameFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        if (existingDictionary.TryGetValue(countryCode, out string countryName))
        {
            return countryName;
        }
        return string.Empty;
    }

    // TASK 6: Verifica si un código existe en el diccionario
    public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode)
    {
        return existingDictionary.ContainsKey(countryCode);
    }

    // TASK 7: Actualiza el nombre de un país existente. Si no existe, no hace nada
    public static Dictionary<int, string> UpdateDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        if (existingDictionary.ContainsKey(countryCode))
        {
            existingDictionary[countryCode] = countryName;
        }
        return existingDictionary;
    }

    // TASK 8: Remueve un país del diccionario usando su código
    public static Dictionary<int, string> RemoveCountryFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        existingDictionary.Remove(countryCode);
        return existingDictionary;
    }

    // TASK 9: Encuentra el nombre de país con mayor cantidad de caracteres
    public static string FindLongestCountryName(Dictionary<int, string> existingDictionary)
    {
        string longestName = string.Empty;

        foreach (var countryName in existingDictionary.Values)
        {
            if (countryName.Length > longestName.Length)
            {
                longestName = countryName;
            }
        }

        return longestName;
    }
}