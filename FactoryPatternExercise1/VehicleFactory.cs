using System;
namespace FactoryPatternExercise1
{
    public static class VehicleFactory
    {
        static VehicleFactory()
        {
        }
        public static IVehicle GetVehicle(int numberOfTires)
        {
            
                switch (numberOfTires)
                {
                    case 2:
                        return new Motorcycle();
                    case 4:
                        return new SUV();
                    default:
                        return null;

                }
            

        }
    }
}
