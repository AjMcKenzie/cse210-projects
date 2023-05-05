using static System.Console;

public class Menu {
    private Board _board;

    public Menu(Board board){
        _board = board;
    }

    public void Display(){
        string responds = "";
        string[] options = {"A","S","Q","F","R"};
        while(responds != "Q")
        {
            while(options.Contains(responds) == false) 
            {
                Write("[A]dd Quote:\n[S]how quotes:\n[F]ind Quote by Author:\n[R]andom Quote:\n[Q]uit\n\nWhat do you want to do? ");
                responds = ReadLine() ?? String.Empty;
                responds = responds.ToUpper();
            }
            switch (responds)
            {
                case "Q":
                    Environment.Exit(0);
                    break;
                case "A":
                    Write("Please enter your quote: ");
                    string quote = ReadLine() ?? String.Empty;
                    Write("Please enter your author: ");
                    string author = ReadLine() ?? String.Empty;
                    Write("Please enter your source: ");
                    string source = ReadLine() ?? String.Empty;
                    Write("Please enter your source url: ");
                    string sourceUrl = ReadLine() ?? String.Empty;
                    
                    _board.AddQuote(new Quote(author,quote,new Source(source,sourceUrl)));
                    break;
                case "S":
                    _board.ShowQuotes();
                    break;
                case "F":
                    Write("Please enter your author: ");
                    author = ReadLine() ?? String.Empty;
                    _board.FindQuotesByAuthor(author);
                    break;
                case "R":
                    _board.GetRandomQuote();
                    break;
            }
            responds = "";
        }
    }
}