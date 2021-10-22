using Homework_Car.Classes;
using Homework_Car.Helpers;
using System;

namespace Homework_Car
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (Vehicle vehicle in VehiclesDB.Vehicles)
            {
                vehicle.PrintVehicle();
                Validator.Validate(vehicle);
            }
        }
    }
}