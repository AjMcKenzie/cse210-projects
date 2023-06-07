using static System.Console;
using System.Globalization;

public class Entry
{
    private string _entry;
    private DateTime _date;
    private string _prompt;


    public Entry(string entry, string prompt)
    {
        _date = DateTime.Now;
        _entry = entry;
        _prompt =prompt;
    }

    // public void ReaddEntry(){

    // }

    public string GetEntry()
    {
        return $"Date:{_date: dd/MM/yyyy}\nPrompt: {_prompt}\n{_entry}\n";
    }
}