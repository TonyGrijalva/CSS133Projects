using System;
using System.Collections.Generic;

namespace CS_133_Projects
{
    public class Program
    {
        static void Main()
        {

            browser myBrowser = new browser();

            myBrowser.AddPage("www.SULearning.com");
            myBrowser.AddPage("www.google.com");
            myBrowser.AddPage("www.facebook.com");

            myBrowser.PrintPages();
            myBrowser.UndoPage();
            myBrowser.PrintPages();


         

        }
    }

    public class browser
    {
        private Stack<string> PageStack = new Stack<string>();

        private Stack<string> undoPageStack = new Stack<string>();

        public void AddPage(string newPage)
        {
            PageStack.Push(newPage);
        }

        public void PrintPages()
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