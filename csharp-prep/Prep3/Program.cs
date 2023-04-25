using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = " ";
        int guessedNumber = 0;
        int numberOfGuesses = 0;
    do{

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        
        do{

            Write("What is your guess? ");
            string userInput = ReadLine();
            guessedNumber = int.Parse(userInput);

            if (guessedNumber > magicNumber){
                WriteLine("Lower");
                numberOfGuesses++;
            }
            else if (guessedNumber < magicNumber){
                WriteLine("Higher");
                numberOfGuesses++;
            }
            else if (guessedNumber == magicNumber){
                WriteLine("You guessed it");
            }

         }while (guessedNumber != magicNumber);
        WriteLine($"You guessed: {numberOfGuesses} times.");

        Write("Do you want to play again(yes)?  ");
        playAgain = ReadLine();

       }while (playAgain.ToLower() == "yes");

    }
}