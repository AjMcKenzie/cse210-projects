using static System.Console;
using System;
using System.Diagnostics;

public class BreathingActivity : Activity
{


    public BreathingActivity() : base()
    {
        SetActivityName("Breathing Activity");

        SetActivityDescription("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
    }

    public void RunBreathingActivity()
    {
        RunActivityParentStart();
        DisplayInOut();
        RunActivityParentEnd();
    }

    public void DisplayInOut()
    {
        int time = GetUserSessionLengthInput() * 1000;
        int intervalTime = 10000;
        int intervals = time / intervalTime;

        for(int i = 0; i < intervals; i++)
        {
            Write("Breathe in... ");
            CountUp();
            WriteLine();
            
            Write("Breathe out... "); 
            Countdown();
            WriteLine();
        }
    }

    private void Countdown()
    {
        for (int i = 5; i > 0; i--)
        {
            Write(i);
            Thread.Sleep(1000);
            Write("\b \b");
        }
    }
    private void CountUp()
    {
        for (int i = 1; i <= 5; i++)
        {
            Write(i);
            Thread.Sleep(1000);
            Write("\b \b");
        }
    }

}