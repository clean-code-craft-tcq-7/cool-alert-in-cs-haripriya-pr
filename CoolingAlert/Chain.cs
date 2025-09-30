namespace CoolingAlert;

// ----------- STEP 6 -----------------

// Chain the BatteryDataModel to Action
public static class Chain
{
    public static void BatteryDataToAction(BatteryDataModel batteryData, IActuators actuators)
    {
        if (Classify.ClassifyBatteryState(batteryData) == BatteryState.BatteryAlert)
        {
            actuators.EmailSender("manager@battery.com", "Battery Alert", "Battery temperature is too high", "noreply@battery.com");
        }
    }
}

// ----------- STEP 6 code ends -------
