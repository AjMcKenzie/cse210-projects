using static System.Console;

public class Journal{

    private List<Prompt> _prompts = new List<Prompt>();
    private List<Entry> _entries = new List<Entry>();

    public Journal(){
        _prompts.Add(new Prompt("What was the most memorable thing that happened today?"));
        _prompts.Add(new Prompt("What did I learn today?"));
        _prompts.Add(new Prompt("What was the biggest challenge I faced today?"));
        _prompts.Add(new Prompt("Who made me smile today?"));
        _prompts.Add(new Prompt("What am I grateful for today?"));
    }

    private void NicePrint(string item){
        WriteLine("---------------------------------");
        WriteLine($"Prompt: {item}");
        WriteLine("---------------------------------");
    }

    public void ShowPrompt(){
        var random = new Random();
        var randomNumber = random.Next(0, _prompts.Count());
        NicePrint(_prompts[randomNumber].GetPrompt());
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
}