using System;
using System.Collections.Generic;

namespace CS_133_Projects
{
    public class Program
    {
        static void Main()
        {
            
            Stack<string> webpage = new Stack<string>();

           
            webpage.Push("www.SULearning.com");

            foreach (var item in webpage)
            {
                Console.WriteLine(item);
            }

            string previousPage = webpage.Peek();

            Console.WriteLine(previousPage);

            foreach (var item in webpage)
            {
                Console.WriteLine(item);
            }

            string forwardOnePage = webpage.Pop();

            Console.WriteLine(forwardOnePage);

            foreach (var item in webpage)
            {
                Console.WriteLine(item);
            }

          
        }
    }
   
}