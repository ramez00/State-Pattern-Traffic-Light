
class Program
{
    static void Main(string[] args)
    {
        TrafficLight trafficLight = new TrafficLight();
        for (int i = 0; i < 6; i++)
        {
            trafficLight.ReportState();
            trafficLight.Change();
        }
    }
}


public class TrafficLight
{
    private string _state;

    public TrafficLight()
    {
        _state = "Red";
    }

    public void Change()
    {
        if (_state == "Red")
        {
            Console.WriteLine("Changing from Red to Green.");
            _state = "Green";
        }
        else if (_state == "Green")
        {
            Console.WriteLine("Changing from Green to Yellow.");
            _state = "Yellow";
        }
        else if (_state == "Yellow")
        {
            Console.WriteLine("Changing from Yellow to Red.");
            _state = "Red";
        }
    }

    public void ReportState() => Console.WriteLine($"Current State: {_state}");
}