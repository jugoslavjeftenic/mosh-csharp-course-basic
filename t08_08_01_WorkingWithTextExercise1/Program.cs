namespace t08_08_01_WorkingWithTextExercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program and ask the user to enter a few numbers separated by a hyphen.
            // Work out if the numbers are consecutive.
            // For example, if the input is "5-6-7-8-9" or "20-19-18-17-16",
            // display a message: "Consecutive"; otherwise, display "Not Consecutive".

            Console.WriteLine("Enter at least two numbers separated by a hyphen (example \"5-6-7-8-9\"):");
            var input = Console.ReadLine();

            char[] delimiterChars = { ' ', ',', '.', ':', ';', '-', '\t' };
            string[]? inputArray = input?.Split(delimiterChars, StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);

            if (inputArray == null || inputArray.Length < 2)
            {
                Console.WriteLine("Invalid List. Please re-try.");
                System.Environment.Exit(13);
            }

            int[] numbers = Array.ConvertAll(inputArray, s => int.TryParse(s, out var x) ? x : -1);
            if (numbers.Length < 2)
            {
                Console.WriteLine("Invalid List. Please re-try.");
                System.Environment.Exit(13);
            }

            bool isAscConsecutive = false;
            bool isDscConsecutive = false;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] + 1 != numbers[i + 1])
                {
                    isAscConsecutive = false;
                    break;
                }
                isAscConsecutive = true;
            }

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] - 1 != numbers[i + 1])
                {
                    isDscConsecutive = false;
                    break;
                }
                isDscConsecutive = true;
            }

            if (isAscConsecutive || isDscConsecutive)
            {
                Console.WriteLine("Consecutive");
            }
            else
            {
                Console.WriteLine("Not Consecutive");
            }
        }
    }
}