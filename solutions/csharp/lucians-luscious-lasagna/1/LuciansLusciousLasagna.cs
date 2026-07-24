class Lasagna
{
    int expectedMinutes = 40;
    
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven()
    {
        return expectedMinutes;
    }

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int minutes)
    {
        return expectedMinutes - minutes;
    }

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int layer)
    {
        int timeNeeded = 2;
        return timeNeeded * layer;
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layer, int minutesInOven)
    {
        int totalPrepTime = PreparationTimeInMinutes(layer);
        int totalTime = minutesInOven + totalPrepTime;
        
        return totalTime;
    }
}

