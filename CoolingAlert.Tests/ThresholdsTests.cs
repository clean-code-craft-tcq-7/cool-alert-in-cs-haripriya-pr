using Xunit;

namespace CoolingAlert.Tests;

// ----------- STEP 5 -----------------

public class ThresholdsTests
{
    [Fact]
    public void CoolingDependentThresholds()
    {
        float passiveLimit = Thresholds.AlertTemperatureForCoolingType(ThermalManagementType.ThermalPassive);
        float hiActiveLimit = Thresholds.AlertTemperatureForCoolingType(ThermalManagementType.ThermalActive);
        float medActiveLimit = Thresholds.AlertTemperatureForCoolingType(ThermalManagementType.ThermalHybrid);

        Assert.True(passiveLimit < medActiveLimit);
        Assert.True(medActiveLimit < hiActiveLimit);
    }
}

// ----------- STEP 5 code ends -------
