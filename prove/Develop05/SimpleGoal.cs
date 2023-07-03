using static System.Console;

public class SimpleGoal: Goal{

    new protected string _type = "SimpleGoal";

    public SimpleGoal(){}
    
    public SimpleGoal(string name, int points, string description, bool status):base(name, points, description, status){
    }

    public SimpleGoal(string name, int points, string description):base(name, points, description){
    }

    override public string GetSaveData(){
        return $"{_type}|{_name}|{_rewardPoints}|{_description}|{_status}";
    }

    override public void OverwriteGoal(string saveData){
            string[] dataList = saveData.Split("|");
            _name = dataList[1];
            _rewardPoints = int.Parse(dataList[2]);
            _description = dataList[3];
            _status = bool.Parse(dataList[4]);
        }

    override public string GetDisplay(){

        if (_status){
            return $"[X] {_name}({_description})";
        }
        else{
            return$"[ ] {_name}({_description})";
        }
        
    }
        
}