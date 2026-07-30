class RemoteControlCar
{
    public int battery = 100;
    
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        int distances = (100 - battery) * 20;

        if (battery == 100) 
        {
            return "Driven 0 meters";
        } 
        else 
        {
            return $"Driven {distances} meters";
        }
        
    }

    public string BatteryDisplay()
    {
        if (battery == 100)
        {
            return "Battery at 100%";
        }
        else if (battery == 0)
        {
            return "Battery empty";
        }
        else
        {
            return $"Battery at {battery}%";
        }
    }

    public void Drive()
    {
        if (battery == 0)
        {
            battery = 0;
        } else
        {
            battery--;
        }
    }
}
