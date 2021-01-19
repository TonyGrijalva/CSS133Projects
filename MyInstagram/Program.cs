using System;
using System.Collections.Generic;

namespace MyInstagram
{
    class Program
    {
        static void Main(string[] args)
        {
            myInstagram myInstagram = new myInstagram();

            myInstagram.UserName = "Marcos";
            myInstagram.TotalViews = 126;
            myInstagram.Likes = 98;
            myInstagram.Comments = new List<string>();
            myInstagram.Comments.Add("Hey! I like your account!");
            myInstagram.Comments.Add("How have you been?");
            myInstagram.Comments.Add("Great picture!");
            myInstagram.Comments.Add("I love this picture of you!");

            Console.WriteLine("The User " + myInstagram.UserName +
                              " has a total of " + myInstagram.TotalViews +
                              " views, and " + myInstagram.Likes + " likes.");
            Console.WriteLine("These are the comments: ");
            foreach(var item in myInstagram.Comments)
            {
                Console.WriteLine(item);
            }


        }
    }
}
public class myInstagram
{
    public string UserName { get; set; }
    public int TotalViews { get; set; }
    public int Likes { get; set; }
    public List<string> Comments { get; set; }
}