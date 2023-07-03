using static System.Console;

public class Menu {

    private List<Goal> _goalList = new List<Goal>();
    private int _pointCount = 0;
    private string _filePath = "Goals.txt";
    private string _menuDisplay = """
    1. Create a Goal
    2. List Goals
    3. Record an Event
    4. Save Goals
    5. Load Goals
    6. Quit
    Select an option (1-6):  
    """;
    private string _goalTypes = """
    1. Simple Goal
    2. Eternal Goal
    3. Checklist Goal
    Select an option (1-3): 
    """;
    private string _userInput = "";
    private bool _running = false; 

    public Menu(){}
    public Menu(List<Goal> goalList){
        _goalList = goalList;
    }

    public void DisplayMenu(){
        _running = true;
        while(_running){
            Console.Clear();
            WriteLine($"Points earned: {_pointCount}");
            WriteLine(_menuDisplay);
            _userInput = ReadLine();

            if(_userInput =="1"){
                CreateGoal();
                continue;
            }
            else if(_userInput =="2"){
                Console.Clear();
                WriteLine($"Points earned: {_pointCount}");
                ListGoals();
                continue;
            }
            else if(_userInput =="3"){
                RecordEvent();
                continue;
            }
            else if(_userInput =="4"){
                SaveGoalList();
                continue;
            }
            else if(_userInput =="5"){
                LoadGoalsList();
                continue;
            }
            else if(_userInput =="6"){
                _running = false;
                Environment.Exit(0);
            }
            else{
                WriteLine("Invalid input, enter integer 1-6");
                ReadLine();
            }
        }
    }

    private void CreateGoal(){
        Console.Clear();
            WriteLine("Select the type of goal you would like to create:");
            WriteLine(_goalTypes);
            _userInput = ReadLine();

            if(_userInput =="1"){
                Write("Enter goal name: ");
                string _name = ReadLine();
                Write("Enter the number of points you receive: ");
                int _rewardPoints = int.Parse(ReadLine());
                Write("Enter goal description: ");
                string _description = ReadLine();

                SimpleGoal myGoal = new SimpleGoal(_name, _rewardPoints, _description);
                _goalList.Add(myGoal);
            }
            else if(_userInput =="2"){
                Write("Enter goal name: ");
                string _name = ReadLine();
                Write("Enter the number of points you receive: ");
                int _rewardPoints = int.Parse(ReadLine());
                Write("Enter goal description: ");
                string _description = ReadLine();

                EternalGoal myGoal = new EternalGoal(_name, _rewardPoints, _description);
                _goalList.Add(myGoal);
            }
            else if(_userInput =="3"){
                Write("Enter goal name: ");
                string _name = ReadLine();
                Write("Enter the number of points you receive: ");
                int _rewardPoints = int.Parse(ReadLine());
                Write("Enter goal description: ");
                string _description = ReadLine();
                Write("Enter the number of times it must be completed to earn a bonus: ");
                int _timesToComplete = int.Parse(ReadLine());
                Write("Enter Bonus Point Value: ");
                int _bonusRewardValue = int.Parse(ReadLine());


                ChecklistGoal myGoal = new ChecklistGoal(_name, _rewardPoints, _description, _timesToComplete, _bonusRewardValue);
                _goalList.Add(myGoal);
            }

            else{
                WriteLine("Invalid input, enter integer 1-3");
            }

        WriteLine("Press Enter to continue");
        ReadLine();
    }

    private void ListGoals(){
        int _count = 0;
        foreach(Goal goal in _goalList){
            _count += 1;
            WriteLine($"{_count}. {goal.GetDisplay()}");
        }

        WriteLine("Press Enter to continue");
        ReadLine();

    }

    private void LoadGoal(string saveData){

        string[] _dataList = saveData.Split("|");

        if(_dataList[0] == "SimpleGoal"){
            SimpleGoal output = new SimpleGoal();
            output.OverwriteGoal(saveData);
            _goalList.Add(output); 
        }
        else if(_dataList[0] == "EternalGoal"){
            EternalGoal output = new EternalGoal();
            output.OverwriteGoal(saveData);
            _goalList.Add(output); 
        }
        else if(_dataList[0] == "ChecklistGoal"){
            ChecklistGoal output = new ChecklistGoal();
            output.OverwriteGoal(saveData);
            _goalList.Add(output); 
        }
        else{
            WriteLine("Loading Error: String Invalid");
        }

    }

    private void RecordEvent(){
        WriteLine("Select a Goal");
        
        int _count = 0;
        foreach(Goal goal in _goalList){
            _count += 1;
            WriteLine($"{_count}. {goal.GetDisplay()}");
        }

        int _selection = int.Parse(ReadLine());

        _selection -= 1;

        _pointCount += _goalList[_selection].CompleteGoal();

        WriteLine("Press Enter to continue");
        ReadLine();
    }

    
    private void SaveGoalList(){
        List<string> _stringList = new List<string>();

        foreach(Goal goal in _goalList){
            _stringList.Add(goal.GetSaveData());
        }

        RecordResultsToFile(_stringList);

        WriteLine("Success! Press Enter to continue");
        ReadLine();
    }

    private void RecordResultsToFile(List<string> data){
        Write("Enter new file name (Goals.txt):");
        string _newFileName = ReadLine();
        if(string.IsNullOrEmpty(_newFileName))
        {
            _newFileName = "Goals.txt";
        }
        
        using(StreamWriter outputFile = new StreamWriter(_newFileName))
            {
                outputFile.WriteLine($"{_pointCount}");

                foreach(string line in data)
                    {outputFile.WriteLine($"{line}");}
            }
    }

    private void LoadGoalsList(){

        Write("Enter file name (Goals.txt):");
        string _fileName = ReadLine();

         if(string.IsNullOrEmpty(_fileName))
        {
            _fileName = "Goals.txt";
        }


        string[] lines = System.IO.File.ReadAllLines(_fileName);

        _pointCount = int.Parse(lines[0]);

        

        foreach(string line in lines[1..]){
            LoadGoal(line);
        }

        WriteLine("Success! Press Enter to continue");
        ReadLine();
    }
}