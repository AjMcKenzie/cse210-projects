using static System.Console;

public class Loanable{
    private bool _isCheckedIn = true;
    protected string _title;


    public Loanable(string title){
        _title = title;
    }

    public void CheckOut(){
        _isCheckedIn = false;
    }

    public void CheckIn(){
        _isCheckedIn = true;

    }

    public virtual void Display(){
        WriteLine($"Available: {_isCheckedIn}");
    }
}