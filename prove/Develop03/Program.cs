
using System;
using System.Collections.Generic;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        // Reference reference = new Reference("John", 3, 16);
        // Scripture scripture = new Scripture(reference, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

        Reference reference = new Reference("Proverbs", 3, 3, 6);
        Scripture scripture = new Scripture(reference, "Let not mercy and truth forsake thee; bind them about thy neck, write them upon the table of thine heart. So shalt thou find favour and good understanding in the sight of God and man. Trust in the Lord with all thine heart, and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");


        
        WriteLine(reference.GetReference());
        scripture.Display();
        WriteLine(" ");
        WriteLine("Press Enter to continue or type 'quit' to exit.");

        while (true)
        {
            string input = ReadLine();
            if (input == "quit")
                break;

            scripture.HideRandomWord();
            Clear();
            WriteLine(reference.GetReference());
            scripture.Display();
            WriteLine(" ");
            WriteLine("Press Enter to continue or type 'quit' to exit.");

            if (scripture.AllWordsHidden)
                break;
        }
    }
}