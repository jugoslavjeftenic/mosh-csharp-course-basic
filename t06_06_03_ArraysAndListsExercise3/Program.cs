using System;

namespace t06_06_03_ArraysAndListsExercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program and ask the user to enter 5 numbers.
            // If a number has been previously entered, display an error message and ask the user to re-try.
            // Once the user successfully enters 5 unique numbers, sort them and display the result on the console.

            int[] numbers = new int[5];
            int attempt = 5;

            while (attempt > 0)
            {
                Console.Write($"Enter a number [attempt {attempt}]: ");
                var input = Console.ReadLine();

                if (int.TryParse(input, out int number))
                {
                    if (!numbers.Contains(number))
                    {
                        attempt--;
                        numbers[attempt] = number;
                    }
                    else
                    {
                        Console.WriteLine("Number has been previously entered.");
                    }
                }
                else
                {
                    Console.WriteLine("Wrong number.");
                }
            }

            Array.Sort(numbers);
            foreach (var n in numbers)
            {
                Console.Write($"{n}, ");
            }
        }
    }
}