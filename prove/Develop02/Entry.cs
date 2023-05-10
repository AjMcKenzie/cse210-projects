using static System.Console;
using System.Globalization;

public class Entry{
    private string _entry = "";
    private DateTime _date;

    public Entry(string entry){
        _date = DateTime.Now;
        _entry = entry;

    }
    
    public string GetEntry(){
        return $"Date: {_date.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)}\n{_entry}";
    }

}