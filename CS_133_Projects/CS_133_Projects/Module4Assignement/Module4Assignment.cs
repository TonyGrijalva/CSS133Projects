using System;
namespace CS_133_Projects.Module_3
{
    public class Module_3_Assignment
    {
        public Module_3_Assignment()
        {
            Cake myClass = new Cake();
            myClass.flavor = "Vanilla";


            Cake myClass2 = new Cake();
            myClass2.flavor = "Chocolate";
        }
    }
}

public class Cake
{
    public string Flavor { get; set; }

    public void ThisIsAMethod<T>(T myParameter)
    {
        this.Flavor = myParameter.ToString();
    }
}
