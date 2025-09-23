using Xunit;

namespace CoolingAlert.Tests;

// ----------- STEP 6 code starts -------
/*
public class ActuatorStub : IActuators
{
    public string EmailTo { get; private set; } = string.Empty;
    public string EmailSubject { get; private set; } = string.Empty;
    public string EmailBody { get; private set; } = string.Empty;
    public string EmailFrom { get; private set; } = string.Empty;

    public bool EmailSender(string to, string subject, string body, string from)
    {
        EmailTo = to;
        EmailSubject = subject;
        EmailBody = body;
        EmailFrom = from;
        return true; // Success
    }
}

public class ChainTests
{
    [Fact]
    public void BatteryDataToAction()
    {
        var batteryData = new BatteryDataModel { BatteryId = 10342, ThermalManagementType = ThermalManagementType.ThermalHybrid, Temperature = 60 };
        var actuatorStub = new ActuatorStub();

        Chain.BatteryDataToAction(batteryData, actuatorStub);

        Assert.Equal("manager@battery.com", actuatorStub.EmailTo);
    }
}
*/
// ----------- STEP 6 code ends -------
