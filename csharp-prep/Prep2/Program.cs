using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        Write("What is your grade percentage? ");
        string userInput = ReadLine();
        float grade = float.Parse(userInput);

        char letter = ' ';
        char sign = ' ';
        float remainder;

        if (grade >= 90){
            letter = 'A';
        }
        else if (grade >= 80){
            letter = 'B';
        }
        else if (grade >= 70){
            letter = 'C';
        }
        else if (grade >= 60){
            letter = 'D';
        }
        else{
            letter = 'F';
        }

        remainder = grade % 10;

        if (remainder >= 7){
            sign = '+';
        }
        else if (remainder < 3){
            sign = '-';
        }
        if (grade >= 93 || grade < 60){
            sign = ' ';
        }

        WriteLine($"Your grade is: {letter}{sign}");

        if (grade >= 70){
            WriteLine("You passed!");
        }
        else{
            WriteLine("Better luck next time.");
        }
    }
}