
using StatePattern_Traffic_Light.StatePattern;

class Program
{
    static void Main(string[] args)
    {
        TrafficLight light = new TrafficLight();

        light.ReportState(); // Red
        light.Change();      // Red -> Green
        light.ReportState(); // Green
        light.Change();      // Green -> Yellow
        light.ReportState(); // Yellow
        light.Change();      // Yellow -> Red
        light.ReportState(); // Red
    }
}
