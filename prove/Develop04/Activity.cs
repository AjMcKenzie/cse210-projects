using System;
using System.Diagnostics;
using static System.Console;

public class Activity
{
    private string _startingMessage;
    private string _endingMessage;
    private string _activityDescription;
    private string _activityName;
    static int _spinnerCounter = 0;
    static int _userSessionLengthInput = 0;


    public Activity()
    {
        _spinnerCounter = _userSessionLengthInput = 0;
    }

    public void SetActivityName(string activityName)
    {
        _activityName = activityName;
    }
    public void SetActivityDescription(string activityDescription)
    {
        _activityDescription = activityDescription;
    }

    public int GetUserSessionLengthInput()
    {
        return _userSessionLengthInput;
    }
    public void DisplayStartingtMessage()
    {
        _startingMessage = $"Welcome to the {_activityName}.";
        WriteLine(_startingMessage);
        WriteLine();
    }

    public void DisplayDescription()
    {
        WriteLine(_activityDescription);
        WriteLine();
    }
    public void DisplayEndingMessage()
    {
        _endingMessage = $"You have complete {_userSessionLengthInput} seconds of the {_activityName}.";

        WriteLine();
        WriteLine("Well done!");
        DisplaySpinner(3);
        WriteLine();
        WriteLine(_endingMessage);
        DisplaySpinner(5);
        Console.Clear();
    }

    public void DisplaySpinner(int numSecondsToRun)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        while (stopwatch.ElapsedMilliseconds / 1000 < numSecondsToRun)
        {
            _spinnerCounter++;
            switch (_spinnerCounter % 4)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Thread.Sleep(200);
        }

        Write(" ");
    }

    public void DisplayCountdown(int numSecondsToRun)
    {
        for (int i = numSecondsToRun; i >= 1; i--)
        {
            Write($"You may begin in: {i}");
            Console.SetCursorPosition(0, Console.CursorTop);
            Thread.Sleep(1000);
        }
    }

    public void DisplayGetSessionLength()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        _userSessionLengthInput = int.Parse(Console.ReadLine());
    }

    public void DisplayGetReady()
    {
        WriteLine("Get ready...");
        DisplaySpinner(5);
    }

    public void RunActivityParentStart()
    {
        DisplayStartingtMessage();
        DisplayDescription();
        DisplayGetSessionLength();
        DisplayGetReady();
        Console.Clear();
    }

    public void RunActivityParentEnd()
    {
        DisplayEndingMessage();
    }

}