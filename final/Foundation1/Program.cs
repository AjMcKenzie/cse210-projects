using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        Video video0 = new Video("How to drink", "Jane Doe", 210, "John Smith", "Thanks!");
        Video video1 = new Video("What color is the Sky, really?", "ConspireNut", 400, "Bob Green", "Now I know the truth!");
        Video video2 = new Video("Fake Video", "Josh Gordian", 310, "Cody Wright", "I thought this was real!");
        Video video3 = new Video("Somehow I Mange", "Micheal Scott", 530, "Dwight Schrute ", "Great Video.");
        
        video0.Display();
        video1.Display();
        video2.Display();
        video3.Display();
    }
}