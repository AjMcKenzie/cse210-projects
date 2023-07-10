using static System.Console;

public class Lectures:Event{
    private string _speaker;
    private int _capacity;

    public Lectures(string title, string description, string date, double time, Address address, string type, string speakerName, int capacity) : base (title, description, date, time, address, type)
    {
        _speaker = speakerName;
        _capacity = capacity;
    }

    public override void StandardDetails(){
        base.StandardDetails();
        WriteLine($"{_speaker}, {_capacity}");

    }

}