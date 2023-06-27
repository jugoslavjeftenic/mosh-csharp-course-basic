using System;

namespace t05_12_05_ControlFlowExercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program and ask the user to enter a series of numbers separated by comma.
            // Find the maximum of the numbers and display it on the console.
            // For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.

            Console.WriteLine("Enter a series of numbers separated by comma (example \"5, 3, 8, 1, 4\"):");
            var input = Console.ReadLine();

            char[] delimiterChars = { ' ', ',', '.', ':', ';', '\t' };
            var inputArray = input?.Split(delimiterChars, StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);

            int maximum = 0;

            if (inputArray?.Length > 0)
            {
                int[] numbers = new int[inputArray.Length];

                for (int i = 0; i < inputArray.Length; i++)
                {
                    if (int.TryParse(inputArray[i], out int numb))
                    {
                        numbers[i] = numb;
                    }
                    else
                    {
                        numbers[i] = 0;
                    }
                }

                maximum = numbers[0];
                foreach (var number in numbers)
                {
                    if (maximum < number)
                    {
                        maximum = number;
                    }
                }
            }

            Console.WriteLine($"Maximum of the numbers is: {maximum}.");
        }
    }
}