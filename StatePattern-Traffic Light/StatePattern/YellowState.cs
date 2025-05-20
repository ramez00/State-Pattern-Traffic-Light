
namespace StatePattern_Traffic_Light.StatePattern;
public class YellowState : ITrafficLightState
{
    // 3. Concrete State
    public string GetColor() => "Yellow";
    public void Handel(TrafficLight context)
    {
        Console.WriteLine("Switching from Yellow to Red");
        context.SetState(new RedState());
    }
}
