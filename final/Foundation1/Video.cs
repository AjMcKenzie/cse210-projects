using System;
using System.Collections.Generic;
using static System.Console;

public class Video{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length){
        _title = title;
        _author = author;
        _length = length;
    }

    public void addComment(Comment comment){
        _comments.Add(comment);
    }
   

    public void Display(){
        WriteLine($"\"{_title}\" -{_author} | {_length}s");
        WriteLine($"{_comments.Count} Comments:");
        foreach (Comment comment in _comments)
            {
                comment.DisplayComment();
            }
                WriteLine("");
    }




}