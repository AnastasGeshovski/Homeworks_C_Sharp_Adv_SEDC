using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_Car
{
    public class Car : Vehicle
    {
        public int FuelTank { get; set; }
        public string Countrie { get; set; }
        public Car(int id, string type, int year, int batchNumber, int fuelTank, string countrie) : base(id, type, year, batchNumber)
        {
            FuelTank = fuelTank;
            Countrie = countrie;
        }

        public override void PrintVehicle()
        {
            Console.WriteLine($"type - {Type} countrie -  {Countrie}");

        }
    }
}