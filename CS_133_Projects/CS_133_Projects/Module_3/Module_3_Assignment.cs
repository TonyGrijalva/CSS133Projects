using System;
namespace CS_133_Projects.Module_3
{
    public class Module_3_Assignment
    {
        public Module_3_Assignment()
        {
            Cake<string> myClass = new Cake<string>();
            myClass.Flavor = "Vanilla";


            Cake<string> myClass2 = new Cake<string>();
            myClass2.Flavor = "Chocolate";
        }
    }
}

public class Cake<T>
{
    public T Flavor { get; set; }
}
