using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        List<int> listOfNumbers = new List<int>();
        string playAgain = " ";
        int guessedNumber = 0;
        int numberOfGuesses;
    do{
        listOfNumbers.Clear();
        numberOfGuesses = 0;

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        
        do{

            Write("What is your guess? ");
            string userInput = ReadLine();
            guessedNumber = int.Parse(userInput);

            if (guessedNumber > magicNumber){
                WriteLine("Guess Lower");
                listOfNumbers.Add(guessedNumber);
                numberOfGuesses++;
            }
            else if (guessedNumber < magicNumber){
                WriteLine("Guess Higher");
                listOfNumbers.Add(guessedNumber);
                numberOfGuesses++;
            }
            else if (guessedNumber == magicNumber){
                WriteLine("You guessed it!");
            }

         }while (guessedNumber != magicNumber);
        WriteLine($"You guessed it in: {numberOfGuesses} times.");

        Write($"Your guesses: ");
        foreach (int number in listOfNumbers){
            if (number == listOfNumbers.Last())
            {
                Write($"{number}");
            }
            else 
            {
                Write($"{number}, ");
            }
        }

        WriteLine();
        Write("Do you want to play again(yes)? ");
        playAgain = ReadLine();

       }while (playAgain.ToLower() == "yes" || playAgain.ToLower() == "y");

    }
}