using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcome(){
        WriteLine("Welcome to the Program!");
    }

    static string PromptUserName (){
        Write("What is your name? ");
        string name = ReadLine();
        return name;
    }
    static int PromptUserNumber (){
        Write("Enter your favorite number: ");
        int number = int.Parse(ReadLine());
        return number;
    }

    static int SquareNumber (int number){
        int square = (int)Math.Pow(number, 2);
        return square;
    }

    static void DisplayResult(string name, int square){
        WriteLine($"{name}, the square of your number is {square}");
    } 
}