using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {

        Assignment sam = new Assignment("Samuel Bennett", "Multiplication");
        MathAssignment math1 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        WritingAssignment writing1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");

        WriteLine(sam.GetSummary());
        WriteLine("");

        WriteLine(math1.GetSummary());
        WriteLine(math1.GetHomeworkList());
        
        WriteLine("");

        WriteLine(writing1.GetSummary());
        WriteLine(writing1.GetWritingInformation());
    }
}