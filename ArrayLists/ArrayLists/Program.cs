using System;
using System.Collections;

namespace ArrayLists
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] simpleArray = new int[5];
            simpleArray[0] = 1;
            simpleArray[1] = 2;
            simpleArray[2] = 3;
            simpleArray[3] = 4;
            simpleArray[4] = 5;

            ArrayList myArrayList = new ArrayList();
            myClass myNewClass = new myClass();
            myNewClass.myProperty = "Something inside the property";

            myArrayList.Add(1);
            myArrayList.Add(2);
            myArrayList.Add("string");
            myArrayList.Add(false);
            myArrayList.Add(new object());
            myArrayList.Add(myNewClass.myProperty);
            

            foreach(var item in myArrayList)
            {
                Console.Write(item + ",");
            }
        }
    }
}

public class myClass
{
    public string myProperty { get; set; }
}