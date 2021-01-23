using System;
using System.Collections.Generic;

namespace Restaurant_Program
{
    class Program
    {


        static void Main()
        {


            Restaurant myRestaurant = new Restaurant();

            myRestaurant.AddPeopleIntoTheQueue("First diner waiting to be seated");
            myRestaurant.AddPeopleIntoTheQueue("Second diner waiting to be seated");
            myRestaurant.AddPeopleIntoTheQueue("Third diner waiting to be seated");
            myRestaurant.AddPeopleIntoTheQueue("Fourth diner waiting to be seated");
            myRestaurant.AddPeopleIntoTheQueue("Fifth diner waiting to be seated");


            myRestaurant.DinerHasBeenSeated();


            myRestaurant.AddPeopleIntoTheQueue("First diner seated");
            myRestaurant.AddPeopleIntoTheQueue("Second seated");
            myRestaurant.AddPeopleIntoTheQueue("Third seated");
            myRestaurant.AddPeopleIntoTheQueue("Fourth seated");
            myRestaurant.AddPeopleIntoTheQueue("Fifth seated");


            myRestaurant.AddDishesInTheDirtyStack("First table's dirty dishes");
            myRestaurant.AddDishesInTheDirtyStack("Second table's dirty dishes");
            myRestaurant.AddDishesInTheDirtyStack("Third table's dirty dishes");
            myRestaurant.AddDishesInTheDirtyStack("Fourth table's dirty dishes");
            myRestaurant.AddDishesInTheDirtyStack("Fifth table's dirty dishes");


            myRestaurant.AddDishesInTheCleanStack("First table's clean dishes");
            myRestaurant.AddDishesInTheCleanStack("Second table's clean dishes");
            myRestaurant.AddDishesInTheCleanStack("Third table's clean dishes");
            myRestaurant.AddDishesInTheCleanStack("Fourth table's clean dishes");
            myRestaurant.AddDishesInTheCleanStack("Fifth table's clean dishes");


            myRestaurant.DinerHasEatenPaidAndLeft();

            myRestaurant.WaiterHasCleanedTheTable();

            myRestaurant.ShowMeHowManyDinersIHave();

            myRestaurant.ShowMeTheActualDiners();
        }


        public class Restaurant
        {
            private Queue<string> waitingQueue = new Queue<string>();

            public void AddPeopleIntoTheQueue(string parameter)
            {
                waitingQueue.Enqueue(parameter);

            }


            public void DinerHasBeenSeated()
            {
                waitingQueue.Dequeue();
            }

            public void DinerHasEatenPaidAndLeft()
            {
                waitingQueue.Dequeue();
            }


            public void WaiterHasCleanedTheTable()
            {
                waitingQueue.Dequeue();
            }


            private Queue<string> seatedQueue = new Queue<string>();

            public void PeopleSitting(string parameter)
            {
                waitingQueue.Enqueue(parameter);

            }


            public void ShowMeHowManyDinersIHave()
            {
                Console.WriteLine("I have " + waitingQueue.Count + " diners");

            }

            public void ShowMeTheActualDiners()
            {
                foreach (var item in waitingQueue)
                {
                    Console.WriteLine("Diner " + item);
                }

            }


            private Stack<string> dirtyDish = new Stack<string>();

            public void AddDishesInTheDirtyStack(string newDish)
            {
                dirtyDish.Push(newDish);
            }

            private Stack<string> cleanDish = new Stack<string>();

            public void AddDishesInTheCleanStack(string newDish)
            {
                cleanDish.Push(newDish);
            }
        }

      
    }
}