using static System.Console;

public class EternalGoal: Goal{

    new protected string _type = "EternalGoal";
    new private string _status = "Eternal";

    public EternalGoal(){}

    public EternalGoal(string name, int points, string description):base(name, points, description){
    }

    override public int CompleteGoal(){
        Console.WriteLine($"You completed the {_name}!");
        return GetRewardPoints();
    }

    override public string GetDisplay(){

        return $"[ ] {_name}({_description}) -- {_status}";
        
    }

    override public string GetSaveData(){
        return $"{_type}|{_name}|{_rewardPoints}|{_description}|{_status}";
    }

    override public void OverwriteGoal(string saveData){
            string[] dataList = saveData.Split("|");

            _name = dataList[1];
            _rewardPoints = int.Parse(dataList[2]);
            _description = dataList[3];
            _status = dataList[4];
        }
}