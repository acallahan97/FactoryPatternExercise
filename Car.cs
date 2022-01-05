using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    class Car : IVehicle
    {
        public string EngineNoise { get; set; }
        public bool IsDriveable { get; set; }
        public void Drive()
        {
            Console.WriteLine("In drive mode");
        }
        
    }
}
