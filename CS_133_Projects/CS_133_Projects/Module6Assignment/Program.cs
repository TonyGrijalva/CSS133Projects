using System;
using System.Collections.Generic;

namespace Module6
{
    class Program
    {
        static void Main()
        {

            Hospital myHospital = new Hospital();

            myHospital.AddPatientsIntoTheQueue("First Patient");
            myHospital.AddPatientsIntoTheQueue("Second Patient");
            myHospital.AddPatientsIntoTheQueue("Third Patient");
            myHospital.AddPatientsIntoTheQueue("Fourth Patient");
            myHospital.AddPatientsIntoTheQueue("Fifth Patient");


            myHospital.RemovePatientFromTheQueue();

            myHospital.ShowMeThePatientsPending();
        }
    }

    public class Hospital
    {
        private Queue<string> waitingQueue = new Queue<string>();
        private Queue<string> attendedQueue = new Queue<string>();

        public void AddPatientsIntoTheQueue(string nameOfpatient)
        {
            waitingQueue.Enqueue(nameOfpatient);

        }

        public void HowManyPatientsDoWeHaveOnTheQueue()
        {
            Console.WriteLine("The hospital has this many patients in the waiting room: " + waitingQueue.Count);
        }

        public void RemovePatientFromTheQueue()
        {
            string patient = waitingQueue.Dequeue();
            attendedQueue.Enqueue(patient);
        }

        public void ShowMeThePatientsPending()
        {
            foreach (var patient in waitingQueue) 
            {
                Console.WriteLine("These are the patients left in the queue: " + patient);


            }
        }

    }
}