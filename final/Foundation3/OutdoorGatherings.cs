using static System.Console;

public class OutdoorGathering:Event{
    public string _weather;

    public OutdoorGathering(string title, string description, string date, double time, Address address, string type, string weather) : base(title, description, date, time, address, type){
        _weather = weather;
    }


    public override void FullDetails()
    {
        base.FullDetails();
        WriteLine($"Weather: {_weather}");
    }
}