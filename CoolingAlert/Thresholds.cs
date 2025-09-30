using System.Collections.Generic;

namespace CoolingAlert;

// ----------- STEP 5 -----------------

// Refactor for duplication. Deprecate old interface in favor of new one.
public static class Thresholds
{
    private static readonly IReadOnlyDictionary<ThermalManagementType, float> thresholds =
        new Dictionary<ThermalManagementType, float>
        {
            { ThermalManagementType.ThermalPassive, 40.0f },
            { ThermalManagementType.ThermalHybrid, 50.0f },
            { ThermalManagementType.ThermalActive, 55.0f }
        };

    public static float AlertTemperatureForCoolingType(ThermalManagementType type)
    {
        if (thresholds.TryGetValue(type, out var value))
        {
            return value;
        }
        return 0.0f;
    }
}

// ----------- STEP 5 code ends -------
