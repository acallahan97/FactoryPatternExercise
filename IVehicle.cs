using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    interface IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Sorry, can't text I'm driving");
        }
    }
}
