using static System.Console;

public class Book : Loanable{
    // private string _title;
    private string _isbn;
    private long _upc;

    public Book(string title, string isbn, long upc) : base(title){
        // _title = title;
        _isbn = isbn;
        _upc = upc;
    }

    public void ShowBookDetails(){
        WriteLine($"{_title}: {_isbn} :: {_upc}");
    }


    public override void Display()
    {
        ShowBookDetails();
        base.Display();

    }
}