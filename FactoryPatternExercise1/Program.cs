using System;

namespace FactoryPatternExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many tires would you like your vehicle to have?");
            Console.WriteLine("Please enter 2 or 4.");
            var tireCount = int.Parse(Console.ReadLine());
            Console.Clear();
            IVehicle choice = VehicleFactory.GetVehicle(tireCount);
            Console.WriteLine($"Let's take this {choice.Make} for a spin!");
            do
            {
                Console.WriteLine("Select from the following");
                Console.WriteLine("Enter 1 : Turn on vehicle");
                Console.WriteLine("Enter 2 : Switch gears");
                Console.WriteLine("Enter 3 : Drive");
                var choice2 = int.Parse(Console.ReadLine());
                Console.Clear();
                if (choice2 == 1)
                {
                    choice.TurnOnEngine();
                }
                else if (choice2 == 2)
                {
                    choice.ShiftGears();

                }
                else if (choice2 == 3)
                {
                    choice.Drive();

                }

            } while (choice.Movement == false);



        }

    }
}
