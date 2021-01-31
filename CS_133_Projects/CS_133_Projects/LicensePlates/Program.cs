using System;
using System.Collections.Generic;

namespace LicensePlates
{
    class Program
    {
        static void Main()
        {
            DMV myDMV = new DMV();

            Vehicle myVehicle = new Vehicle();
            myVehicle.LicensePlate = "1ABC23";
            myVehicle.VehicleType = "2017 Chevrolet Volt";

            myDMV.AddVehicle(myVehicle);

            Vehicle myVehicle2 = new Vehicle();
            myVehicle2.LicensePlate = "2DEF34";
            myVehicle2.VehicleType = "2015 Hyundai Elantra";

            myDMV.AddVehicle(myVehicle);

            Vehicle myVehicle3 = new Vehicle();
            myVehicle3.LicensePlate = "3GHI45";
            myVehicle3.VehicleType = "1995 Ford Ranger";

            myDMV.AddVehicle(myVehicle);


        }
    }
}

public class DMV
{
    public HashSet<Vehicle> mySet = new HashSet<Vehicle>();

    public void AddVehicle(Vehicle vehicle)
    {
        bool result = mySet.Add(vehicle);

        if(result==false)
        {
            Console.WriteLine("License plate number already exists");
        }
    }

 

}

public class Vehicle
{
    public string LicensePlate { get; set; }
    public string VehicleType { get; set; }
}