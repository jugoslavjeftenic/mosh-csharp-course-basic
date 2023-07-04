namespace t06_06_05_ArraysAndListsExercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10).
            // If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try;
            // otherwise, display the 3 smallest numbers in the list.

            Console.WriteLine("Enter a minimum of 5 numbers separated by comma (example \"5, 1, 9, 2, 10\"):");
            var input = Console.ReadLine();

            char[] delimiterChars = { ' ', ',', '.', ':', ';', '\t' };
            var inputArray = input?.Split(delimiterChars, StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);

            if (inputArray == null || inputArray.Length < 5)
            {
                Console.WriteLine("Invalid List. Please re-try.");
                System.Environment.Exit(13);
            }

            Array.Sort(inputArray);

            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"{inputArray[i]}, ");
            }
        }
    }
}