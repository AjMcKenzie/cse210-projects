using static System.Console;

public class Journal{

    private List<Entry> _entries = new List<Entry>();

    public Journal(){}

     public void ShowPrompt()
    {
        Prompt prompt = new Prompt();
        NicePrint(prompt.GetRandomPrompt());
    }

    private void NicePrint(string item){
        WriteLine("---------------------------------");
        WriteLine($"Prompt: {item}");
        WriteLine("---------------------------------");
    }

    public void AddEntry(Entry entry){
        _entries.Add(entry);

    }

    public void ShowEntries(){
        if (_entries.Count == 0){
            WriteLine("No entries yet. Start by writing a new entry.");
        }
        else{
            foreach (Entry entry in _entries){
                WriteLine();
                WriteLine(entry.GetEntry());
            }
        }
    }

    public List<Entry> GetEntries()
    {
        return _entries;
    }
}