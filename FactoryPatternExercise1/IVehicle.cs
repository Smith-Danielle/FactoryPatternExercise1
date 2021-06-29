using System;
namespace FactoryPatternExercise1
{
    public interface IVehicle
    {
        
        public string Make { get; set; }
        public int Tires { get; set; }
        public bool CarisOn { get; set; }
        public int Gear { get; set; }
        public bool Movement { get; set; }


        public void TurnOnEngine();
        public void ShiftGears();
        public void Drive();
        

    }

    
}
