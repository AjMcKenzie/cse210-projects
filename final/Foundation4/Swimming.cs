using static System.Console;

public class Swimming: Activity{
    private int _laps;

    public Swimming(double length, int laps): base(length){
        _laps = laps;
    }

    public override double CalculateDistance(){
        _distance = (_laps * 50 / 1000 * 0.62);
        return _distance;
    }

    public override double CalculateSpeed(){
        _speed = ((_distance / GetLength()) * 60);
        return _speed;
    }

    public override double CalculatePace(){
        _pace = (GetLength() / _distance);
        return _pace;
    }

    public override void GetSummary(){
        WriteLine($"{GetDate()} Swimming ({GetLength()} min) Distance: {CalculateDistance().ToString("F1")} miles, Speed: {CalculateSpeed().ToString("F1")} mph, Pace: {CalculatePace().ToString("F1")} min per mile");

    }
}