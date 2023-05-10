using static System.Console;

public class Menu {
    private Journal _journal;

    public Menu(Journal journal){
        _journal = journal;
    }

    public void Display(){
        string responds = "";
        string[] options = {"1", "2", "3", "4", "5"};
        while(responds != "5")
        {
            while(options.Contains(responds) == false) 
            {
                WriteLine("");
                Write("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\n\nWhat do you want to do? ");
                responds = ReadLine() ?? String.Empty;
                responds = responds.ToUpper();
            }
            switch (responds)
            {
                case "5":
                    Environment.Exit(0);
                    break;

                case "1":
                    _journal.ShowPrompt();
                    Write("> ");
                    string entry = ReadLine() ?? String.Empty;
                    _journal.AddEntry(new Entry(entry));
                    break;
                
                case "2":
                    _journal.ShowEntries();
                    break;

                case "3":
                    break;
                
                case "4":
                    break;
            }
            responds = "";
        }
    }
}