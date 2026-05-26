using System;

class RemoteControlCar
{
    // Variables internas para guardar el estado del coche
    private int _distanceDriven = 0;
    private int _batteryLevel = 100;

    // Método estático para 'comprar' (crear) un coche nuevo
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    // Muestra la distancia acumulada
    public string DistanceDisplay()
    {
        return $"Driven {_distanceDriven} meters";
    }

    // Muestra el porcentaje de batería actual
    public string BatteryDisplay()
    {
        if (_batteryLevel == 0)
        {
            return "Battery empty";
        }
        return $"Battery at {_batteryLevel}%";
    }

    // NUEVO MÉTODO: Actualiza el estado del coche al conducir
    public void Drive()
    {
        // Solo maneja si todavía queda batería
        if (_batteryLevel > 0)
        {
            _distanceDriven += 20;
            _batteryLevel -= 1;
        }
    }
}