using static System.Console;

public class Reception:Event{
    private string _email;

    public Reception(string title, string description, string date, double time, Address address, string type, string email) : base (title, description, date, time, address, type){
        _email = email;
    }

    public override void FullDetails()
    {
        base.FullDetails();
        WriteLine($"Email: {_email}");
    }
}
