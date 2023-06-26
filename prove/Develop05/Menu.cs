using static System.Console;

public class Menu{
    private int totalPoints = 0;

    public void Display(){

        WriteLine($"You have {totalPoints} points");

        WriteLine("Menu Options:");
        WriteLine("1. Create New Goal");
        WriteLine("2. List Goals");
        WriteLine("3. Save Goals");
        WriteLine("4. Load Goals");
        WriteLine("5. Record Event");
        WriteLine("6. Quit");
        Write("Select a choice from the menu: ");
        int choice = int.Parse(ReadLine());
        WriteLine();
    }
        
    

}