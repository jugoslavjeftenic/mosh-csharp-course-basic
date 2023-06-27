namespace t05_12_03_ControlFlowExercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program and ask the user to enter a number.
            // Compute the factorial of the number and print it on the console.
            // For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

            while (true)
            {
                Console.Write("Enter a number or \"ok\" to exit: ");
                var input = Console.ReadLine();
                if (int.TryParse(input, out int number))
                {
                    int[] numbers = new int[number];
                    for(int i=0;i<numbers.Length; i++)
                    {
                        numbers[i] = number--;
                        Console.WriteLine(numbers[i]);
                    }
                }
                //else if (input?.Trim().ToLower() == "ok")
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