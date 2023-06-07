using static System.Console;
public class Scripture
{
    private List<Word> words;
    private Random random;
    private List<Word> hiddenWords;
    private Reference reference;

    public bool AllWordsHidden => words.TrueForAll(w => w.Hidden);

    public Scripture(Reference newReference, string text)
    {
        words = new List<Word>();
        random = new Random();
        reference = newReference;

        
        string[] wordArray = text.Split(' ');
        foreach (string word in wordArray)
        {
            words.Add(new Word(word));
        }
    }

    public void Display()
    {
        Console.Clear();

        reference.GetReference();
        foreach (Word word in words)
        {
            word.Display();
        }
    }


    public void HideRandomWord()
    {
        List<Word> visibleWords = words.FindAll(w => !w.Hidden);
        if (visibleWords.Count > 0)
        {
            int randomIndex = random.Next(visibleWords.Count);
            visibleWords[randomIndex].HideWord();
        }
    }
}