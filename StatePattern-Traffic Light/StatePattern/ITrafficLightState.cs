namespace StatePattern_Traffic_Light.StatePattern;

public interface ITrafficLightState
{
    // 2. State interface
    void Handel(TrafficLight trafficLight);
    string GetColor();
}