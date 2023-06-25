namespace t05_04_01_ConditionalsExercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program and ask the user to enter a number.
            // The number should be between 1 to 10.
            // If the user enters a valid number, display "Valid" on the console.
            // Otherwise, display "Invalid".
            // (This logic is used a lot in applications where values entered into input boxes need to be validated.)

            Console.WriteLine("Please enter number between 1 and 10:");
            if (byte.TryParse(Console.ReadLine(), out byte number))
            {
                if (number > 0 && number < 11)
                {
                    Console.WriteLine("Valid");
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }
            else
            {
                Console.WriteLine("Wrong input. Please try again and enter number between 1 and 10.");
            }
        }
    }
}