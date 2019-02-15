using System;

namespace Mileage
{
    public static class Program
    {
        public static void Main()
        {
            // Get input from the user and save it to a variable
            Console.Write("How many miles have you driven?");
            string milesInput = Console.ReadLine();
            int milesDriven = int.Parse(milesInput);

            //Get input from the user and save it to a second variable
            Console.Write("How many gallons of gas have you consumed?");
            string gasInput = Console.ReadLine();
            int gasConsumed = int.Parse(gasInput);

            

            int perGallon = milesDriven / gasConsumed;

            // Output - Your miles per gallon is (computed value)
            Console.Write($"Your miles per gallon is {perGallon}");


            Console.ReadLine();
        }
    }
}
