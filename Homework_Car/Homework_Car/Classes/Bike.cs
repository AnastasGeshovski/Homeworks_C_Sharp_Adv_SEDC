using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_Car.Classes
{
    public class Bike : Vehicle
    {
        public string Color { get; set; }
        public Bike(int id, string type, int year, int batchNumber, string color) : base(id, type, year, batchNumber)
        {
            Color = color;
        }
        public override void PrintVehicle()
        {
            Console.WriteLine($" Year of production - {YearOfProduction} color - {Color} ");
        }
    }
}