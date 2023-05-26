using static System.Console;

public class Menu {
    private Journal _journal;
     private FileHandler _fileHandler;
     private Prompt _prompt;

    public Menu(Journal journal, FileHandler fileHandler){
        _journal = journal;
        _fileHandler = fileHandler;
        _prompt = new Prompt();
    }

    public void Display(){
        string responds = "";
        string[] options = {"W", "D", "L", "S", "C", "Q"};
        List<string> prompts = new List<string>();

        while(responds != "Q")
        {
            while(options.Contains(responds) == false) 
            {
                Console.Clear();
                Write("[W]rite\n[D]isplay\n[L]oad\n[S]ave\n[C]lear entries\n[Q]uit\n\nWhat do you want to do? ");
                responds = ReadLine() ?? String.Empty;
                responds = responds.ToUpper();
            }
            switch (responds)
            {
                case "Q":
                    Environment.Exit(0);
                    break;

                case "W":
                    Console.Clear();
                    string prompt = _prompt.GetRandomPrompt();
                    _prompt.NicePrint(prompt);
                    Write("> ");
                    string entry = ReadLine() ?? String.Empty;
                    _journal.AddEntry(new Entry(entry, prompt));
                    break;
                
                case "D":
                    Console.Clear();
                    _journal.ShowEntries();
                    break;

                case "S":
                     _fileHandler.SaveEntries(_journal.GetEntries());
                    break;
                
                case "L":
                    _fileHandler.LoadEntries();
                    break;
                case "C":
                    _journal.ClearEntries();
                    
                    break;
            }
            responds = "";
        }
    }
}