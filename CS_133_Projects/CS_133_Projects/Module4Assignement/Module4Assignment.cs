using System;
namespace CS_133_Projects.Module_4
{
    public class Program

    {
        public void Main()
        {
            Cake myCake = new Cake();
            myCake.Type = "Wedding Cake";
            myCake.AddFlavor<string>("Vanilla");


            Cake myCake2 = new Cake();
            myCake2.Type = "Party Cake";
            myCake2.AddFlavor<string>("Chocolate");
        }
    }
}

public class Cake
{
    public string Flavor { get; set; }
    public string Type { get; set; }
    
    public void AddFlavor<T>(T myParameter)
    {
        this.Flavor = myParameter.ToString();
        {
            Console.WriteLine("My first parameter is: " + myParameter);
        }
        
       
    }
}
