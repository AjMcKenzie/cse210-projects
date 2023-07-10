using static System.Console;

public class Lecture:Event{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string date, double time, Address address, string type, string speakerName, int capacity) : base (title, description, date, time, address, type)
    {
        _speaker = speakerName;
        _capacity = capacity;
    }

    public override void FullDetails(){
        base.FullDetails();
        WriteLine($"Speaker: {_speaker}\nCapacity: {_capacity}");

    }
}