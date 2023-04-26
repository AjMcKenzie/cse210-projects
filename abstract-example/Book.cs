using static System.Console;
public class Book
{
    private string _author;
    private string _name;
    private int _timesRead = 0;
    private bool _available = false;

    public Book(string name, string author)
    {
        _name = name;
        _author = author;
    }

    public void Display()
    {
        WriteLine($"{_name} by {_author}");

        if(!_available)
        {
            WriteLine("Checked Out");
        }
    }

    public bool IsAvailable()
    {
        return _available;
    }
}