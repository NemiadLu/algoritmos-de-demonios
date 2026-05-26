using System;

class RemoteControlCar
{
    private readonly int _speed;
    private readonly int _batteryDrain;
    private int _distanceDriven = 0;
    private int _battery = 100;

    // TASK 1: Constructor con parámetros de velocidad y consumo
    public RemoteControlCar(int speed, int batteryDrain)
    {
        this._speed = speed;
        this._batteryDrain = batteryDrain;
    }

    // TASK 4: Indica si la batería no alcanza para otro movimiento
    public bool BatteryDrained()
    {
        return _battery < _batteryDrain;
    }

    // TASK 3: Devuelve la distancia total recorrida
    public int DistanceDriven()
    {
        return _distanceDriven;
    }

    // TASK 3 & 4: Actualiza la distancia y la batería si es posible conducir
    public void Drive()
    {
        if (!BatteryDrained())
        {
            _distanceDriven += _speed;
            _battery -= _batteryDrain;
        }
    }

    // TASK 5: Método estático para crear el modelo Nitro especial
    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}

class RaceTrack
{
    private readonly int _distance;

    // TASK 2: Constructor para la pista de carreras
    public RaceTrack(int distance)
    {
        this._distance = distance;
    }

    // TASK 6: Determina si el coche puede completar la distancia de la pista
    public bool TryFinishTrack(RemoteControlCar car)
    {
        // Conducimos el coche continuamente hasta que complete la pista o se agote la batería
        while (car.DistanceDriven() < _distance && !car.BatteryDrained())
        {
            car.Drive();
        }

        // Si la distancia recorrida es igual o mayor a la de la pista, la terminó con éxito
        return car.DistanceDriven() >= _distance;
    }
}