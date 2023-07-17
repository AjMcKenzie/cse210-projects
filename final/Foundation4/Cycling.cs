using static System.Console;

public class Cycling: Activity{

    public Cycling(double length, double speed) : base(length){
        _speed = speed;
    }

    public override double CalculatePace(){
        _pace = (60 / _speed);
        return _pace;
    }

    public override double CalculateDistance(){
        _distance = ((GetLength() * _speed) / 60);
        return _distance;
    }

    public override double CalculateSpeed()
    {
        return _speed;   
    }


    public override void GetSummary(){
        WriteLine($"{GetDate()} Cycling ({GetLength()} min) Distance: {CalculateDistance()} miles, Speed: {_speed.ToString("F1")} mph, Pace: {CalculatePace().ToString("F1")} min per mile");

    }

}