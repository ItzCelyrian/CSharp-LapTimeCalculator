using System;

namespace LapTimeCalculator
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine("Forza Horizon 5 - Lap Time Calculator");

            var laps = ReadNumberWithLimit("\nHow many laps does the race consist of? (1-50) ", 50, 1);
            var minutes = ReadNumberWithLimit("\nHow many minutes does a single lap take? (0-60) ", 60, 0);
            var seconds = ReadNumberWithLimit("\nHow many seconds does a single lap take? (0-60) ", 60, 0);
            
            while (minutes == 0 && seconds == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A lap should take at least 1 second.");
                Console.ForegroundColor = ConsoleColor.Gray;
                minutes = ReadNumberWithLimit("\nHow many minutes does a single lap take? (0-60) ", 60, 0);
                seconds = ReadNumberWithLimit("\nHow many seconds does a single lap take? (0-60) ", 60, 0);
            }
            
            var lapTime = (minutes * 60) + seconds;
            var finalTime = TimeSpan.FromSeconds(laps * lapTime);
            var outputTime = finalTime.ToString(@"hh\:mm\:ss");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"It will take {outputTime} to drive {laps} Laps.");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nPress any Key to exit...");
            Console.ReadLine();
        }

        private static int ReadNumberWithLimit(string prompt, int maxValue = Int32.MaxValue, int minValue = Int32.MinValue)
        {
            int returnVal;

            while (true)
            {
                Console.Write(prompt);

                if (int.TryParse(Console.ReadLine(), out returnVal) && returnVal >= minValue && returnVal <= maxValue)
                {
                    break;
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter a valid number within the given limits.");
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            return returnVal;
        }
    }
}
