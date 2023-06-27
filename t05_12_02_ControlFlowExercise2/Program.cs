namespace t05_12_02_ControlFlowExercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program and continuously ask the user to enter a number or "ok" to exit.
            // Calculate the sum of all the previously entered numbers and display it on the console.

            int sum = 0;
            while (true)
            {
                Console.Write("Enter a number or \"ok\" to exit: ");
                var input = Console.ReadLine();
                if (int.TryParse(input, out int number))
                {
                    sum += number;
                    Console.WriteLine("Sum of numbers: " + sum);
                }
                else if (input?.ToLower() == "ok")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong input. Enter a number or \"ok\" to exit: ");
                }
            }
        }
    }
}