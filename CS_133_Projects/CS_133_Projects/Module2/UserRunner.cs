using System;
using System.Collections.Generic;

namespace CS_133_Projects
{
    public class UserRunner
    {
        static void Main(String[] args) {

            User Tony = new User();
            Tony.username = "Gumby";
            Tony.totViews = 10;
            Tony.likes = 100;
            Tony.comments = new List<string>();
            Tony.comments.Add("Great picture!");
            Tony.comments.Add("What's with that face?");


            Console.WriteLine("The user is: " + Tony.username);
            Console.WriteLine("The user has a total of " + Tony.totViews +
            " views");
            Console.WriteLine("The user has a total of " + Tony.likes + "likes");
            foreach (string tacos in Tony.comments)
            {
                Console.WriteLine("There is a comment saying: " + tacos);

            }
            Console.WriteLine();
        }

        
    }
}
