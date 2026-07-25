static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        if (speed >= 1 && speed <= 4)
        {
            return 1;
        } else if (speed >= 5 && speed <= 8)
        {
            return 0.9;
        } else if (speed == 9)
        {
            return 0.8;
        } else if (speed == 10)
        {
            return 0.77;
        } else {
            return 0;
        }
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        int carsPerHour = 221;
        double productionRate = SuccessRate(speed) * speed;

        return carsPerHour * productionRate;
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        int productionPerHour = System.Convert.ToInt32(ProductionRatePerHour(speed));
        return productionPerHour / 60;
    }
}
