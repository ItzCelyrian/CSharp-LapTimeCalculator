using System;

namespace LapTimeCalculator
{
    internal static class Program
    {
        private static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Forza Horizon 5 - Time Calculator\n");

            // Definition for the amount of Laps
            Console.WriteLine("How many Laps does the race consist of?\n");
            var laps = Convert.ToInt64(Console.ReadLine());
            
            // Definition of the time a single Lap is taking (Minute Counter)
            Console.WriteLine("How many Minutes does a single Lap have?\n");
            var minutes = Convert.ToDouble(Console.ReadLine());
            
            // Definition of the time a single Lap is taking (Second Counter)
            Console.WriteLine("How many Seconds does a single Lap have? (Decimals are given with ',')\n");
            var seconds = Convert.ToDouble(Console.ReadLine());
            
            // Cases for if laps and time is exceeding the limit
            if (laps is > 50 or <= 0)
            {
                laps = 1;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your given laps were invalid, the lap-counter was automatically adjusted to '1'.\n");
            }
            
            if (minutes is >= 60 or < 0)
            {
                minutes = 1;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your given minutes were invalid, the minute-counter was automatically adjusted to '1'.\n");
            }

            if (seconds is >= 60 or < 0)
            {
                seconds = 1;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your given seconds were invalid, the second-counter was automatically adjusted to '1'.\n");
            }

            // Calculation of the Output Time
            var lapTime = ( minutes * 60 ) + seconds;
            var finalTime = TimeSpan.FromSeconds( laps * lapTime );
            var outputTime = finalTime .ToString(@"hh\:mm\:ss\:fff");
            
            // Output of the Variable after the calculation
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"The Race will take {outputTime} to be completed within {laps} Laps.\n");
            
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Press any Key to exit...");
            Console.ReadLine();
        }
    }
}