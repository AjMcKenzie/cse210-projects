using static System.Console;

public class ChecklistGoal:Goal {

    new protected string _type = "ChecklistGoal";   
    
    private int _timesCompleted = 0;
    private int _timesToComplete = 3;
    private int _bonusRewardValue = 10;

    public ChecklistGoal(){}

    public ChecklistGoal(string name, int points, string description, int timesToComplete, int bonusRewardValue):base(name, points, description){
        _timesToComplete = timesToComplete;
        _bonusRewardValue = bonusRewardValue;
    }
    
    public ChecklistGoal(string name, int points, string description, bool status, int timesCompleted, int timesToComplete, int bonusRewardValue):base(name, points, description, status){
        _timesCompleted = timesCompleted;
        _timesToComplete = timesToComplete;
        _bonusRewardValue = bonusRewardValue;
    }

    public ChecklistGoal(string name, int points, string description, int timesCompleted, int timesToComplete, int bonusRewardValue):base(name, points, description){
        _timesCompleted = timesCompleted;
        _timesToComplete = timesToComplete;
        _bonusRewardValue = bonusRewardValue;
    }
    
     public override string GetDisplay(){

        if (_status == true || _timesCompleted == _timesToComplete){
                return $"[X] {_name}({_description}) -- Competed: {_timesCompleted}/{_timesToComplete}";
            }
            else{
                return $"[ ] {_name}({_description}) -- Competed: {_timesCompleted}/{_timesToComplete}";
            } 
        
    }
    
     public override int CompleteGoal(){
        Console.WriteLine($"You {_name} once, good job!");

        _timesCompleted += 1;

        if (_timesCompleted == _timesToComplete){
            _status = true;
            return GetTotalPoints();

        }
        else{
            return GetRewardPoints();
        }
    }

    public int GetTimesCompleted(){
        return _timesCompleted;
    }

    public void setTimesCompleted(int timesCompleted){
        _timesCompleted = timesCompleted;
    }

    public int GetTimesToComplete(){
        return _timesToComplete;
    }

    public void setTimesToComplete(int timesToComplete){
        _timesToComplete = timesToComplete;
    }

    public int GetBonusRewardValue(){
        return _bonusRewardValue;
    }

    public int GetTotalPoints(){
        return _rewardPoints + _bonusRewardValue;
    }

    public void setBonusRewardValue(int bonusRewardValue){
        _bonusRewardValue = bonusRewardValue;
    }

     public override string GetSaveData(){
        return $"{_type}|{_name}|{_rewardPoints}|{_description}|{_status}|{_timesCompleted}|{_timesToComplete}|{_bonusRewardValue}";
    }


     public override void OverwriteGoal(string saveData){
            string[] dataList = saveData.Split("|");

            _name = dataList[1];
            _rewardPoints = int.Parse(dataList[2]);
            _description = dataList[3];
            _status = bool.Parse(dataList[4]);
    }


}