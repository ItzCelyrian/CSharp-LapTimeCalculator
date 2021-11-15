using System;

namespace LapTimeCalculator
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine("Forza Horizon 5 - Time Calculator");

            var laps = ReadNumberWithLimit("\nHow many laps does the race consist of? (1-50)", 50, 1);                    // Definition for the amount of Laps

            var minutes = ReadNumberWithLimit("\nHow many minutes does a single lap take? (Min 0)", Int32.MaxValue, 0);   // Definition of the time a single Lap is taking (Minute Counter)

            var seconds = ReadNumberWithLimit("\nHow many seconds does a single lap take? (0-60)");                       // Definition of the time a single Lap is taking (Second Counter)

            var lapTime = (minutes * 60) + seconds;                                                                       // Calculation of the Output Time
            var finalTime = TimeSpan.FromSeconds(laps * lapTime);
            var outputTime = finalTime.ToString(@"hh\:mm\:ss\:fff");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Iw will take {outputTime} to drive {laps} Laps.");                                        // Output of the Variable after the calculation
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("\nPress any Key to exit...");
            Console.ReadLine();
        }

        private static int ReadNumberWithLimit(string prompt, int maxValue = Int32.MaxValue, int minValue = Int32.MinValue)
        {
            var returnVal = 0;
            var isCorrect = false;
            do
            {
                Console.Write(prompt);

                try
                {
                    returnVal = int.Parse(prompt);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a valid number.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    continue;
                }

                Console.ForegroundColor = ConsoleColor.Red;
                isCorrect = returnVal <= minValue && returnVal >= maxValue;
                if (!isCorrect) Console.WriteLine("Please enter a valid number within the given limits.");
                Console.ForegroundColor = ConsoleColor.Gray;
            } while (!isCorrect);

            return returnVal;
        }
    }
}