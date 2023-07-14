using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activitiesList = new List<Activity>();

        Running running = new Running(30, 3);
        activitiesList.Add(running);

        Cycling cycling = new Cycling(50, 18);
        activitiesList.Add(cycling);

        Swimming swimming = new Swimming(60, 50);
        activitiesList.Add(swimming);

        foreach (Activity activity in activitiesList)
        {
            activity.GetSummary();
        }
    }
}