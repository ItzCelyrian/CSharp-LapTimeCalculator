using System;

namespace LapTimeCalculator
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine("Forza Horizon 5 - Time Calculator");
            Console.WriteLine("");

            // Definition for the amount of Laps
            Console.WriteLine("How many Laps does the race consist of?");
            var laps = Convert.ToInt64(Console.ReadLine());

            // Spacer
            Console.WriteLine("");
            
            // Definition of the time a single Lap is taking (Minute Counter)
            Console.WriteLine("How many Minutes does a single Lap have?");
            var minutes = Convert.ToDouble(Console.ReadLine());
            
            // Spacer
            Console.WriteLine("");
            
            // Definition of the time a single Lap is taking (Second Counter)
            Console.WriteLine("How many Seconds does a single Lap have? (Decimals are given with ',')");
            var seconds = Convert.ToDouble(Console.ReadLine());
            
            // Spacer
            Console.WriteLine("");
            
            // Definition of the Vehicle the player is in.
            Console.WriteLine("Which Vehicle are you using for the given race?");
            var vehicle = Convert.ToString(Console.ReadLine());
            
            // Spacer
            Console.WriteLine("");
            
            // Cases for if laps and time is exceeding the limit
            if (laps is > 50 or < 0)
            {
                laps = 1;
                Console.WriteLine("Your given laps were invalid, the lap-counter was automatically adjusted to '1'.");
                Console.WriteLine("");
            }
            
            if (minutes is >= 60 or <= 0)
            {
                minutes = 1;
                Console.WriteLine("Your given minutes were invalid, the minute-counter was automatically adjusted to '1'.");
                Console.WriteLine("");
            }

            if (seconds is >= 60 or <= 0)
            {
                seconds = 1;
                Console.WriteLine("Your given seconds were invalid, the second-counter was automatically adjusted to '1'.");
                Console.WriteLine("");
            }

            // Calculation of the Output Time
            var lapTime = ( minutes * 60 ) + seconds;
            var finalTime = TimeSpan.FromSeconds( laps * lapTime );
            var outputTime = finalTime .ToString(@"hh\:mm\:ss\:fff");
            
            // Output of the Variable after the calculation
            Console.WriteLine($"The {vehicle} will take {outputTime} to drive {laps} Laps.");
            
            // Spacer
            Console.WriteLine("");
            
            Console.WriteLine("Press any Key to exit...");
            Console.ReadLine();
        }
    }
}