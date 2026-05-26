using System;

class Lasagna
{
    // 1. Define el método 'ExpectedMinutesInOven()'
    public int ExpectedMinutesInOven()
    {
        return 40;
    }

    // 2. Define el método 'RemainingMinutesInOven()'
    public int RemainingMinutesInOven(int actualMinutes)
    {
        return ExpectedMinutesInOven() - actualMinutes;
    }

    // 3. Define el método 'PreparationTimeInMinutes()'
    public int PreparationTimeInMinutes(int layers)
    {
        return layers * 2;
    }

    // 4. Define el método 'ElapsedTimeInMinutes()'
    public int ElapsedTimeInMinutes(int layers, int minutesInOven)
    {
        return PreparationTimeInMinutes(layers) + minutesInOven;
    }
}