
namespace StatePattern_Traffic_Light.StatePattern;
public class GreenState : ITrafficLightState
{
    // 3. Concrete State
    public string GetColor() => "Green";
    public void Handel(TrafficLight context)
    {
        Console.WriteLine("Switching from Green to Yellow");
        context.SetState(new YellowState());
    }
}