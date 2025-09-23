namespace CoolingAlert;

public enum BatteryState
{
    BatteryOk,
    BatteryWarning,
    BatteryAlert
}

public sealed class BatteryDataModel
{
    public int BatteryId { get; init; }
    public ThermalManagementType ThermalManagementType { get; init; }
    public int Temperature { get; init; }
}
