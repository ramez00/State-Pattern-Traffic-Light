
namespace StatePattern_Traffic_Light.StatePattern;
public class TrafficLight
{
    // 1. Context class

    private ITrafficLightState _state;

    public TrafficLight()
    {
        _state = new RedState();
    }

    public void Change()
    {
        _state.Handel(this);
    }
    public void SetState(ITrafficLightState state)
    {
        _state = state;
    }
    public void ReportState()
    {
        Console.WriteLine($"Current State: {_state.GetColor()}");
    }

}
