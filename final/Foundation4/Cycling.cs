using static System.Console;

public class Cycling: Activity{
    private double _speed;
    private double _pace;

    public Cycling(double length, double speed) : base(length){
        _speed = speed;
    }

    private double CalculatePace(){
        _pace = Math.Round(60/_speed);
        return _pace;
    }


    public override void GetSummary(){
        // WriteLine($"{GetDate()} Running ({GetLength()} min) Distance: {_distance.ToString("F1")} miles, Speed: {CalculateSpeed().ToString("F1")} mph, Pace: {CalculatePace().ToString("F1")} min per mile");
        WriteLine($"{GetDate()} Cycling ({GetLength()} min) Distance: Speed: {_speed.ToString("F1")} mph, Pace: {CalculatePace().ToString("F1")} min per mile");

    }

}