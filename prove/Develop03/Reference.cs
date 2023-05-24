using static System.Console;

public class Reference{

    private string _book;
    private int _start;
    private int _end;
    private int _chapter;


    public Reference(string book, int chapter, int start, int end){
        _book = book;
        _chapter = chapter;
        _start = start;
        _end = end;
    }

    public Reference(string book, int chapter, int start){
        _book = book;
        _chapter = chapter;
        _start = start;
    }

    public string GetReference(){
        if(_end > 0){
            return $"{_book} {_chapter}:{_start}-{_end}";
        }
        else{
            return $"{_book} {_chapter}:{_start}";
        }

    }
}