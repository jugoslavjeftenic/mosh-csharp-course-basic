namespace t08_08_02_WorkingWithTextExercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program and ask the user to enter a few numbers separated by a hyphen.
            // If the user simply presses Enter, without supplying an input, exit immediately;
            // otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.


            Console.WriteLine("Enter a few numbers separated by a hyphen (example \"5-1-7-8-5\"):");
            var input = Console.ReadLine();

            char[] delimiterChars = { ' ', ',', '.', ':', ';', '-', '\t' };
            string[]? inputArray = input?.Split(delimiterChars, StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);

            if (inputArray == null || inputArray.Length < 1)
            {
                Console.WriteLine("Invalid List. Please re-try.");
                System.Environment.Exit(13);
            }

            int[] numbersArray = Array.ConvertAll(inputArray, s => int.TryParse(s, out var x) ? x : -1);
            var duplicates = numbersArray.GroupBy(x => x)
              .Where(g => g.Count() > 1)
              .Select(y => y.Key)
              .ToList();

            if (duplicates.Count > 0)
            {
                Console.WriteLine("Duplicate");
                Console.WriteLine(String.Join(", ", duplicates));
            }
        }
    }
}