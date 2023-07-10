using static System.Console;

public class Receptions:Event{
    private string _RSVP;

    public Receptions(string title, string description, string date, double time, Address address, string type, string RSVP) : base (title, description, date, time, address, type){

    }
}
