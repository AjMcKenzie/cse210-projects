using static System.Console;

public class Word
{
    private string _text;
    public bool Hidden { get; private set; }

    public Word(string text)
    {
        _text = text;
        Hidden = false;
    }

    public void Display()
    {
        if (Hidden)
        {
            for (int i = 0; i < _text.Length; i++)
            {
                if (char.IsLetterOrDigit(_text[i]))
                {
                    Write("_");
                }
                else
                {
                    Write(_text[i]);
                }
            }
            Write(" ");
        }
        else
            Write($"{_text} ");
    }

    public void HideWord()
    {
        Hidden = true;
    }

     public void ShowWord()
    {
        Hidden = false;
    }
}