namespace t06_06_04_ArraysAndListsExercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program and ask the user to continuously enter a number or type "Quit" to exit.
            // The list of numbers may include duplicates.
            // Display the unique numbers that the user has entered.

            List<int> numbers = new();

            while (true)
            {
                Console.Write($"Enter a number or type \"Quit\" to quit: ");
                var input = Console.ReadLine()?.Trim();

                if (int.TryParse(input, out int number))
                {
                    numbers.Add(number);
                }
                else if (input?.ToLower() == "quit" || input?.ToLower() == "q")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong input.");
                }

                Console.WriteLine(String.Join(", ", numbers.Distinct()));
            }

            //HashSet<int> distinctSet = new(numbers);
            //foreach (var s in distinctSet)
            //{
            //        Console.Write(s+", ");
            //}
        }
    }
}