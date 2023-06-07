using static System.Console;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _start;
    private int _end;

    public Reference(string book, int chapter, int start, int end)
    {
        _book = book;
        _chapter = chapter;
        _start = start;
        _end = end;
    }

    public Reference(string book, int chapter, int start)
    {
        _book = book;
        _chapter = chapter;
        _start = start;
        _end = -1;
    }

    public void GetReference()
    {
        if (_end > 0)
            WriteLine($"{_book} {_chapter}:{_start}-{_end}");
        else
            WriteLine($"{_book} {_chapter}:{_start}");
    }
}