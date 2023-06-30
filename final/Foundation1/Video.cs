using System;
using System.Collections.Generic;
using static System.Console;

public class Video{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length, string commentName, string commentText){
        title = _title;
        author = _author;
        length = _length;
        Comment comment = new Comment(commentName, commentText);
        _comments.Add(comment);
    }


    // public void DisplayComments()
    // {
        
    // }
    
    public void Display(){
        WriteLine($"{_title}, Posted by: {_author}, Length: {_length}");
        foreach (Comment comment in _comments)
            {
                WriteLine(comment.DisplayComment());
            }
    }


}