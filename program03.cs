using System;

namespace program03 {
    class Program {
        static double CalculateAverage(params double[] values) {
            Console.WriteLine("You sent me {0} doubles.", values.Length);

            double sum = 0;
            if (values.Length == 0)
                return sum;
            for (int i =0; i < values.Length; i++)
                sum += values[i];
            return (sum / values.Length);
        }

        // illustrating named parameter
        static void DisplayFancyMessage(ConsoleColor textColor, ConsoleColor backgroundColor, string message) {
            // Store old colors to restore after message is printed
            ConsoleColor oldTextColor = Console.ForegroundColor;
            ConsoleColor oldbackgroundColor = Console.BackgroundColor;

            // set new colors and print message
            Console.ForegroundColor = textColor;
            Console.BackgroundColor = backgroundColor;
            Console.WriteLine(message);

            // Restore previous colors
            Console.ForegroundColor = oldTextColor;
            Console.BackgroundColor = oldbackgroundColor;
        }

        static void Main(string[] args) {
            Console.WriteLine("***** Fun With Methods *****");

            // pass in a comma delimited list of doubles
            double average;
            average = CalculateAverage(4.0, 3.2, 5.7, 64.22, 87.2);
            Console.WriteLine("Average of data is : {0}", average);

            DisplayFancyMessage(message: "Wow! very Fancy indeed", textColor: ConsoleColor.DarkRed,
            backgroundColor: ConsoleColor.White);

            DisplayFancyMessage(ConsoleColor.Blue, message: "Testing...", backgroundColor: ConsoleColor.White);
        }

    }
}