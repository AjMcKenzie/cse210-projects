using static System.Console;

public class Event{
    private string _title;
    private string _description;
    private string _date;
    private double _time; // 24 hour time
    private Address _address {get; set;}
    private string _eventType;


    public Event(string title, string description, string date, double time, Address address, string type){
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _eventType = type;  
    }

    public void ShortDetails(){
        WriteLine($"Event Type: {_eventType}\nTitle: {_title}\nDate: {_date}");
    }
    
    public void StandardDetails(){
        WriteLine($"{_title}\n{_description}\nDate & Time: {_date} @ {_time.ToString("F2")}\nAddress: {_address.GetAddress()}");
    }

    public virtual void FullDetails(){
        WriteLine($"{_title}\n{_description}\nType: {_eventType}\nDate & Time: {_date} @ {_time.ToString("F2")}\nAddress: {_address.GetAddress()}");

    }



}