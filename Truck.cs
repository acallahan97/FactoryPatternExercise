using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    class Truck : IVehicle
    {
        public string Color { get; set; }
        public bool HasFourWheelDrive { get; set; }
        public void Drive()
        {
            Console.WriteLine("Driving a truck");
        }
    }
}
