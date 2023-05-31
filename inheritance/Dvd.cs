using static System.Console;

public class Dvd : Loanable{

    // private string _title;


    public Dvd(string title) : base(title){
        // _title = title;
    }

    public override void Display(){
        WriteLine($"Title: {_title}");
        base.Display();
    }
}