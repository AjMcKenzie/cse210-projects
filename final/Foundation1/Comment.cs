using System;
using System.Collections.Generic;
using static System.Console;

public class Comment{
    private string _name;
    private string _comment;

    public Comment(string name, string comment){
        _name = name;
        _comment = comment;
    }

    public void DisplayComment()
    {
        WriteLine($"\"{_comment}\" -{_name}");
    }
}