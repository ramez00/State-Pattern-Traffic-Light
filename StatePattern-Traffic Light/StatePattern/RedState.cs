
namespace StatePattern_Traffic_Light.StatePattern;
public class RedState : ITrafficLightState
{
    // 3. Concrete State
    public string GetColor() => "Red";

    public void Handel(TrafficLight context)
    {
        Console.WriteLine("Switching from Red to Green");
        context.SetState(new GreenState());
    }
}
