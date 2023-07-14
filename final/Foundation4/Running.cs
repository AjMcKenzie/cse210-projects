using static System.Console;

public class Running: Activity{
    private double _distance;
    private double _speed;
    private double _pace;


    public Running(double length, double distance) : base(length){
        _distance = distance;
    }

    public override double CalculateSpeed(){
        _speed = ((_distance / GetLength()) * 60);
        return _speed;
    }

    public override double CalculatePace(){
        _pace = (GetLength() / _distance);
        return _pace;
    }

    public override double CalculateDistance()
    {
        return _distance;
    }


    public override void GetSummary(){
        WriteLine($"{GetDate()} Running ({GetLength()} min) Distance: {_distance.ToString("F1")} miles, Speed: {CalculateSpeed().ToString("F1")} mph, Pace: {CalculatePace().ToString("F1")} min per mile");
    }
}