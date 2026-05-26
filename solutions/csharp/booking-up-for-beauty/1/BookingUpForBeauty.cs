using System;

static class Appointment
{
    // TASK 1: Convierte el texto descriptivo a DateTime
    public static DateTime Schedule(string appointmentDateDescription)
    {
        return DateTime.Parse(appointmentDateDescription);
    }

    // TASK 2: Comprueba si la fecha ya quedó en el pasado
    public static bool HasPassed(DateTime appointmentDate)
    {
        return appointmentDate < DateTime.Now;
    }

    // TASK 3: Verifica si cae entre las 12:00 y las 17:59
    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {
        return appointmentDate.Hour >= 12 && appointmentDate.Hour < 18;
    }

    // TASK 4: Devuelve la cadena formateada del turno
    public static string Description(DateTime appointmentDate)
    {
        return $"You have an appointment on {appointmentDate.ToString("G")}.";
    }

    // TASK 5: Devuelve el 15 de septiembre del año actual
    public static DateTime AnniversaryDate()
    {
        return new DateTime(DateTime.Now.Year, 9, 15, 0, 0, 0);
    }
}