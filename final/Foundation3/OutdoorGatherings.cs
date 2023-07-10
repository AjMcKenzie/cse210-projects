using static System.Console;

public class OutdoorGatherings:Event{
    public string _weather;

    public OutdoorGatherings(string title, string description, string date, double time, Address address, string type, string weather) : base(title, description, date, time, address, type){

    }
}