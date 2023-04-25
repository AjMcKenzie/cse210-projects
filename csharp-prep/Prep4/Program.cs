using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int newNumber = -1;
        int sum = 0;
        float average = 0;
        int largestNumber = int.MinValue;
        int smallestNumber = int.MaxValue;;

        do{
            Write("Enter a number (Type 0 to end): ");
            string userInput = ReadLine();
            if (string.IsNullOrEmpty(userInput)) {
                continue;
            }
           if (!int.TryParse(userInput, out newNumber)) {
                WriteLine("Please enter an integer.");
                newNumber = -1;
                continue;
            }
            newNumber = int.Parse(userInput);
            if(newNumber != 0){
                numbers.Add(newNumber);
            }
        }while (newNumber != 0);

        foreach (int number in numbers){
            sum += number;
            if (number > largestNumber){
                largestNumber = number;
            }
            if (number > 0 && number < smallestNumber){
                smallestNumber = number;
            }
 
            average = (float)sum / numbers.Count;
        }

        numbers.Sort();

        Write($"The sum is: {sum}");
        WriteLine();
        Write($"The average is: {average}");
        WriteLine();
        Write($"The largest number is: {largestNumber}");
        WriteLine();
        Write($"The smallest positive number is: {smallestNumber}");
        WriteLine();
        WriteLine($"The sorted list is: ");
        foreach (int number in numbers){
            WriteLine(number);
         }

    }
}