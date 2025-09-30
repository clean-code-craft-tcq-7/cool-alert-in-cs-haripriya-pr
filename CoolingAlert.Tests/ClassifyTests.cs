using Xunit;

namespace CoolingAlert.Tests;

// ----------- STEP 5 -----------------

public class ClassifyTests
{
    [Fact]
    public void BatteryOk()
    {
        var batteryData = new BatteryDataModel { BatteryId = 10567, ThermalManagementType = ThermalManagementType.ThermalPassive, Temperature = 25 };
        var state = Classify.ClassifyBatteryState(batteryData);
        Assert.Equal(BatteryState.BatteryOk, state);
    }

    [Fact]
    public void BatteryAlert()
    {
        var batteryData = new BatteryDataModel { BatteryId = 21389, ThermalManagementType = ThermalManagementType.ThermalHybrid, Temperature = 60 };
        var state = Classify.ClassifyBatteryState(batteryData);
        Assert.Equal(BatteryState.BatteryAlert, state);
    }
}

// ----------- STEP 5 code ends -------
