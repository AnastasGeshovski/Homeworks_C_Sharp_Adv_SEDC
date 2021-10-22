using Homework_Car.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_Car.Helpers
{
    public static class VehiclesDB
    {
        public static List<Vehicle> Vehicles;

        static VehiclesDB()
        {
            Vehicles = new List<Vehicle>()
            {
                new Car(269, "MiniVan", 2010, 5678, 5, "China"),
                new Car(237, "Suv", 2011, 5378, 4, "USA"),
                new Bike(327, "RoadBike", 2019, 6978, "Red"),
                new Bike(487, "BMX", 2020, 4698, "Blue"),
                new Vehicle(863, "Plane", 2021, 6347),
                new Vehicle(863, "Motorcycle", 2008, 6312),
            };
        }

    }
}