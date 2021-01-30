using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Module_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory myInventory = new Inventory();

   

            Product myProduct = new Product();

            myInventory.AddProductToTheInventory(myProduct, "WAT");
            myInventory.AddProductToTheInventory(myProduct, "WAT");
            myInventory.AddProductToTheInventory(myProduct, "WAT");
            myInventory.AddProductToTheInventory(myProduct, "WAT");
            myInventory.AddProductToTheInventory(myProduct, "WAT");
            myInventory.AddProductToTheInventory(myProduct, "WAT");
            myInventory.AddProductToTheInventory(myProduct, "WAT");
            myInventory.AddProductToTheInventory(myProduct, "WAT");
            myInventory.AddProductToTheInventory(myProduct, "WAT");
            myInventory.AddProductToTheInventory(myProduct, "WAT");
            myInventory.AddProductToTheInventory(myProduct, "WAT");
            myInventory.AddProductToTheInventory(myProduct, "WAT");
            myInventory.AddProductToTheInventory(myProduct, "WAT");
            myInventory.AddProductToTheInventory(myProduct, "WAT");
            myInventory.AddProductToTheInventory(myProduct, "WAT");
            myInventory.AddProductToTheInventory(myProduct, "WAT");
            myInventory.AddProductToTheInventory(myProduct, "WAT");
            myInventory.AddProductToTheInventory(myProduct, "WAT");
            myInventory.AddProductToTheInventory(myProduct, "WAT");
            myInventory.AddProductToTheInventory(myProduct, "WAT");

            myInventory.HowManySectionsDoWeHave();
            



        }
    }
   
}

public class Inventory
{
    Dictionary<string, Product> myInventory = new Dictionary<string, Product>();
    

    public void AddProductToTheInventory(Product newProduct, string key)
    {
        int count = myInventory.Count;

        bool doesItExist = myInventory.ContainsKey(key);

        if(!doesItExist)
        {
            myInventory.Add(key, newProduct);
        }
        else
        {
            Console.WriteLine("Key already exists");
        }

        
    }

    public void HowManySectionsDoWeHave()
    {
        Console.WriteLine("We have " + myInventory.Count + " sections in use.");
    }
}


public class Product
{
    public string Name { get; set; }
    public string Phone { get; set; }
}