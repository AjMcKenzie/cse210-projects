using static System.Console;

public abstract class Goal{

    protected string _name = "Goal";
    protected int _rewardPoints = 1;
    protected string _description = "Description";

    protected string _type = "Goal";
    protected bool _status = false;

    public Goal(){}

    public Goal(string name, int points, string description, bool status){
        _name = name;
        _rewardPoints = points;
        _description = description;
        _status = status;
    }

    public Goal(string name, int points, string description){
        _name = name;
        _rewardPoints = points;
        _description = description;
    }

    public string GetGoalType(){
        return _type;
    }

    public string GetName(){
        return  _name;
    }

    public void SetName(string name){
        _name = name;
    }

    public string GetDescription(){
        return _description;
    }

    public void GetDescription(string description){
        _description = description;
    }

    public int GetRewardPoints(){
        return _rewardPoints;
    }

    public void SetRewardPoints(int points){
        _rewardPoints = points;
    }

    public bool GetStatus(){
        return _status;
    }

    public void SetStatus(bool status){
        _status = status;
    }

    virtual public int CompleteGoal(){
        Console.WriteLine($"You completed the {_name}!");
        _status = true;
        return GetRewardPoints();
    }

    virtual public string GetSaveData(){
        return $"{_type}|{_name}|{_rewardPoints}|{_description}|{_status}";
    }

    virtual public void OverwriteGoal(string saveData){
            string[] dataList = saveData.Split("|");
            _name = dataList[1];
            _rewardPoints = int.Parse(dataList[2]);
            _description = dataList[3];
            _status = bool.Parse(dataList[4]);
        }
    
    virtual public string GetDisplay(){

        if (_status){
            return $"[X] {_name}: {_description}";
        }
        else{
            return$"[ ] {_name}: {_description}";
        }
        
    }

}