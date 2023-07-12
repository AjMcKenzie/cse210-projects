using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running(30, 3);
        running.GetSummary();

        Cycling cycling = new Cycling(30, 20);
        cycling.GetSummary();

    }
}