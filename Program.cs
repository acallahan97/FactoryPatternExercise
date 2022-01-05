using System;

namespace FactoryPatternExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What kind of vehicle do you want to create? Car or Truck?");
            string UserInput = Console.ReadLine();

            VehicleFactory factory = new VehicleFactory();
            IVehicle myVehicle = factory.CreateVehicle(UserInput);
            myVehicle.Drive();


            Console.WriteLine("Let's make another vehicle.");
            UserInput = Console.ReadLine();
           
        }
    }
}
