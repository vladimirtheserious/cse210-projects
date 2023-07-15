
using System;
using System.Diagnostics;


class Comment
{
    public string _username;
    public string _comment;


    public void Display()
    {
        Console.WriteLine($"Name: {_username}");
        Console.WriteLine("Comment:");
    }
}