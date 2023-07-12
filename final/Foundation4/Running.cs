using static System.Console;

public class Running: Activity{
    private double _distance;
    private double _speed;
    private double _pace;


    public Running(double length, double distance) : base(length){
        _distance = distance;
    }

    private double CalculateSpeed(){
        _speed = Math.Round((_distance / GetLength()) * 60);
        return _speed;
    }

    private double CalculatePace(){
        _pace = Math.Round(GetLength() / _distance);
        return _pace;
    }

    public override void GetSummary(){
        // 03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile

        WriteLine($"{GetDate()} Running ({GetLength()} min) Distance: {_distance.ToString("F1")} miles, Speed: {CalculateSpeed().ToString("F1")} mph, Pace: {CalculatePace().ToString("F1")} min per mile");
    }
}