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

    public string DisplayComment()
    {
        return $"Comment: {_comment}\nMade by: {_name}";
    }
}