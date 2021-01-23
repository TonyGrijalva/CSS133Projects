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

        }
    }

    public class Hospital
    {
        private Queue<string> waitingQueue = new Queue<string>();

        public void AddPatientsIntoTheQueue(string parameter)
        {
            waitingQueue.Enqueue(parameter);

        }

    }
}