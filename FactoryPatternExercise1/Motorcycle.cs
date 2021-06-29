using System;
namespace FactoryPatternExercise1
{
    public class Motorcycle : IVehicle
    {
        public Motorcycle()
        {
            Console.WriteLine("Nice choice! How about a motorcycle?!");
            Console.WriteLine("What make would you prefer?");
            Make = Console.ReadLine();
        }
        public string Make { get; set; }
        public int Tires { get; set; } = 2;
        public bool CarisOn { get; set; } = false;
        public int Gear { get; set; } = 0;
        public bool Movement { get; set; } = false;

        public void TurnOnEngine()
        {
            CarisOn = true;
            Console.WriteLine("Your engine is on and in gear 0.");
        }
        public void ShiftGears()
        {

            if (CarisOn == true)
            {
                Console.WriteLine("Select 1 to shift up or Select 2 to shift down");
                int direction = int.Parse(Console.ReadLine());
                if (direction == 1)
                {
                    if (Gear < 5)
                    {
                        Gear++;
                        Console.WriteLine($"You are now in gear {Gear}.");
                    }
                    else
                    {
                        Console.WriteLine($"You are in gear {Gear}. You cant shift higher than gear 5.");
                    }
                }
                else if (direction == 2)
                {
                    if (Gear > 0)
                    {
                        Gear--;
                        Console.WriteLine($"You are now in gear {Gear}.");
                    }
                    else
                    {
                        Console.WriteLine($"You are in gear {Gear}. You cant shift lower than gear 0.");
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
                Console.WriteLine("Please make sure engine is turned on and in first gear.");
            }
        }
    }
}
