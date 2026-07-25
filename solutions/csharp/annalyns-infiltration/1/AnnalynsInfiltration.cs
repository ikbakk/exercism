static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        if (knightIsAwake) return false;
        
        return true;
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        var cannotBeSpied = !knightIsAwake && !archerIsAwake && !prisonerIsAwake;

        if (cannotBeSpied) return false;
        return true;
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        var cannotSignal = archerIsAwake || !prisonerIsAwake;
        if (cannotSignal) return false;
        return true;
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        var everyoneIsAwake = knightIsAwake && archerIsAwake && prisonerIsAwake;
        var guardsAreSleeping = !knightIsAwake && !archerIsAwake;

        if (petDogIsPresent)
        {
            if (archerIsAwake) return false;
            return true;
        } else {
            if (prisonerIsAwake)
            {
                if (guardsAreSleeping) return true;
                return false;       
            }
            return false;
        }
        
    }
}
