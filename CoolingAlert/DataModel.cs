namespace CoolingAlert;

// ----------- STEP 2 -----------------

// Minimal data-models to pass STEP 2 in tests
public enum CoolingType
{
    PASSIVE_COOLING,
    HI_ACTIVE_COOLING,
    MED_ACTIVE_COOLING
}

public enum ActionType
{
    NO_ALERT,
    ALERT_EMAIL,
}

public sealed class Action
{
    public ActionType ActionType { get; set; }
    public string ActionBody { get; set; } = string.Empty;
}

// ----------- STEP 2 code ends -------
