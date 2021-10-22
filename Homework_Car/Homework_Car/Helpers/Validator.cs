using Homework_Car.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_Car.Helpers
{
    class Validator
    {
        public static void Validate(Vehicle vehicle)
        {
            if (vehicle.Id != 0 && vehicle.Type != " " && vehicle.YearOfProduction != 0)
            {
                Console.WriteLine("The validation was successful");
            }
            else
            {
                Console.WriteLine("The validation was not successful ");
            }
        }
    }
}