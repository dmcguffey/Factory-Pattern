using System.Buffers.Text;
using System.Numerics;
using System;

namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Create a console app that utilizes factory pattern by taking a user’s input of 
            //how many tires are on a vehicle and, based on their input, creates that type of vehicle. 
            //Complete this using an interface. You must have at least 2 subclasses.
            //For instance, if I type 4 into the console, the program would create a car or truck, or if someone types 2 it would create a motorcycle.
            //Feel free to use something other than vehicles if you want to be creative, but the other constraints still apply!

            Console.WriteLine("What are we building?");
            //Decide what home user wants
            string wantedHome = Console.ReadLine();

            IDwelling home = Contractor.buildHome(wantedHome);
            home.build();

        }
    }
}
