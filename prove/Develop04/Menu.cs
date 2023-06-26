using static System.Console;
using System;

public class Menu{
    int breatheCount = 0;
    int reflectCount = 0;
    int listCount = 0;

    public void Display(){
        
    WriteLine("Welcome to the Mindfulness Program!");
    WriteLine();
    bool running = true;
    while (running)
    {
        WriteLine("Please select one of the following activities: ");
        WriteLine("1. Breathing Activity");
        WriteLine("2. Reflecting Activity");
        WriteLine("3. Listing Activity");
        WriteLine("4. Show Amount of times completed");
        WriteLine("5. Quit");
        WriteLine();
        Write("What would you like to do? ");
        int choice = int.Parse(ReadLine());
        WriteLine();

        switch (choice)
        {   
            //Breathing
            case 1:
                Console.Clear();
                BreathingActivity breathing = new BreathingActivity();
                breathing.RunBreathingActivity();
                breatheCount++;
                break;
            //Reflecting
            case 2:
                Console.Clear();
                ReflectingActivity reflection = new ReflectingActivity();
                reflection.RunReflectingActivity();
                reflectCount++;
                break;
            //Listing
            case 3:
                Console.Clear();
                ListingActivity listing = new ListingActivity();
                listing.RunListingActivity();
                listCount++;
                break;
            //Show number of times
            case 4:
                Console.Clear();
                WriteLine("You have completed:");
                WriteLine($"Breathing Activity: {breatheCount} time(s)");
                WriteLine($"Reflecting Activity: {reflectCount} time(s)");
                WriteLine($"Listing Activity: {listCount} time(s)");
                Write("Press enter to go back");
                ReadLine();
                break;
            //Quit
            case 5:
                running = false;
                WriteLine("Great job! You completed the following activities: ");
                WriteLine($"Breathing Activity: {breatheCount} time(s)");
                WriteLine($"Reflecting Activity: {reflectCount} time(s)");
                WriteLine($"Listing Activity: {listCount} time(s)");
                WriteLine();
                WriteLine("Thank you. Have a nice day!");
                break;
            default:
                WriteLine("Invalid input. Please choose one of the following activities.");
                break;
            }
    
        }
    }
    
}