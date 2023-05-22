using static System.Console;

public class Menu {
    private Journal _journal;
     private FileHandler _fileHandler;

    public Menu(Journal journal, FileHandler fileHandler){
        _journal = journal;
        _fileHandler = fileHandler;
    }

    public void Display(){
        string responds = "";
        string[] options = {"W", "D", "L", "S", "Q"};
        while(responds != "Q")
        {
            while(options.Contains(responds) == false) 
            {
                WriteLine("");
                Write("[W]rite\n[D]isplay\n[L]oad\n[S]ave\n[Q]uit\n\nWhat do you want to do? ");
                responds = ReadLine() ?? String.Empty;
                responds = responds.ToUpper();
            }
            switch (responds)
            {
                case "Q":
                    Environment.Exit(0);
                    break;

                case "W":
                    _journal.ShowPrompt();
                    Write("> ");
                    string entry = ReadLine() ?? String.Empty;
                    _journal.AddEntry(new Entry(entry));
                    break;
                
                case "D":
                    _journal.ShowEntries();
                    break;

                case "S":
                     _fileHandler.SaveEntries(_journal.GetEntries());
                    break;
                
                case "L":
                    _fileHandler.LoadEntries();
                    break;
            }
            responds = "";
        }
    }
}