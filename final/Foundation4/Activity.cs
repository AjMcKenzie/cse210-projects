using static System.Console;

public abstract class Activity{
    private string _date;
    private double _length;
    protected double _speed;
    protected double _pace;
    protected double _distance;


    public Activity(double length){
        _length = length;

    }

    public string GetDate(){
        DateTime date = DateTime.Now;
        string _date = date.ToString("dd MMM yyyy");
        return _date;
    }

    public double GetLength(){
        return _length;
    }

    public abstract double CalculateDistance();

    public abstract double CalculateSpeed();

    public abstract double CalculatePace();
    
    public abstract void GetSummary();

}




