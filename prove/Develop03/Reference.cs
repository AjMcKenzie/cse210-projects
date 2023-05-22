using static System.Console;

public class Reference{

    private string _book;
    private int _start;
    private int _end;
    private int _chapter;


    public string Display(){
        return $"{_book} {_chapter}:{_start}-{_end}";
    }

}