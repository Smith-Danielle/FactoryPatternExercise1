using System;
namespace FactoryPatternExercise1
{
    public class SUV : IVehicle
    {
        public SUV()
        {
            Console.WriteLine("Nice choice! How about an SUV?!");
            Console.WriteLine("What make would you prefer?");
            Make = Console.ReadLine();
        }

        
        public string Make { get; set; }
        public int Tires { get; set; } = 4;
        public bool CarisOn { get; set; }
        public int Gear { get; set; } = 0; //0 = Park, 1 = Drive, 2 = Reverse
        public bool Movement { get; set; } = false;

        public void TurnOnEngine()
        {
            CarisOn = true;
            Console.WriteLine("Your engine is on and is in park.");

        }
        public void ShiftGears()
        {
           
            if (CarisOn == true)
            {
                Console.WriteLine("Please select a gear");
                Console.WriteLine("Enter D: Drive");
                Console.WriteLine("Enter R: Reverse");
                Console.WriteLine("Enter P: Park");
                string direction = Console.ReadLine();
                if (direction.ToLower() == "d")
                {
                    if (Gear == 1) 
                    {
                        Console.WriteLine("You are already in Drive,");
                    }
                    else
                    {
                        Gear = 1;
                        Console.WriteLine($"You are now in Drive.");
                    }
                }
                else if (direction.ToLower() == "r")
                {
                    if (Gear == 2)
                    {
                        Console.WriteLine("You are already in Reverse.");
                    }
                    else
                    {
                        Gear = 2;
                        Console.WriteLine($"You are now in Reverse");
                    }
                }
                else if (direction.ToLower() == "p")
                {
                    if (Gear == 0)
                    {
                        Console.WriteLine("You are already in Park");
                    }
                    else
                    {
                        Gear = 0;
                        Console.WriteLine($"You are now in Park.");
                    }
                }

            }
            else
            {
                Console.WriteLine("Please make sure engine is turned on.");
            }

        }
        public void Drive()
        {
            if (CarisOn == true && Gear == 1)
            {
                Console.WriteLine($"The {Make} is driving forward.");
                Movement = true;
            }
            else
            {
                Console.WriteLine("Please make sure engine is turned on and in drive.");
            }
        }
    }
}
