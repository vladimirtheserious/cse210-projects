
using System;
using System.Diagnostics;

class Video
{
    private string _name;
    public string _author;
    public int _seconds;

    public List<Comment> _comments = new List<Comment>();


    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Comment:");

        foreach (Comment comment in _comments)
        {

            comment.Display();
        }
    }
}