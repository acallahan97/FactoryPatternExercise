using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
   class VehicleFactory
    {
       public IVehicle CreateVehicle(string UserInput)
        {
            switch (UserInput.ToLower())
            {
                case "car":
                    return new Car() { EngineNoise = "Vroom Vroom", IsDriveable = true };
                case "truck":
                    return new Truck() { Color = "Red", HasFourWheelDrive = true };
                default:
                    return new Car();
            }
        }
    }
}
