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

    public class Word
    {
        private Stack<string> PageStack = new Stack<string>();

        private Stack<string> undoPageStack = new Stack<string>();

        public void AddPage(string newPage)
        {
            PageStack.Push(newPage);
        }

        public void PrintPage()
        {
            foreach (var item in PageStack)
            {
                Console.WriteLine("The page is the following: "
                                  + item);
            }
        }


        public void UndoPage()
        {
            string lastPage = PageStack.Pop();

            undoPageStack.Push(lastPage);
        }

        public void PrintPageAgain()
        {
            foreach (var item in undoPageStack)
            {
                Console.WriteLine("The page is the following: "
                                  + item);
            }
        }

        public void RedoPage()
        {
            string lastPage = undoPageStack.Pop();

            PageStack.Push(lastPage);
        }

    }
}