using static System.Console;

public class Prompt
{
    private List<string> _prompts = new List<string>()
    {
        "What was the most memorable thing that happened today?",
        "What did I learn today?",
        "What was the biggest challenge I faced today?",
        "Who made me smile today?",
        "What am I grateful for today?",
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, _prompts.Count);
        return _prompts[randomNumber];
    }


    public void NicePrint(string item){
        WriteLine("---------------------------------");
        WriteLine($"Prompt: {item}");
        WriteLine("---------------------------------");
    }
}