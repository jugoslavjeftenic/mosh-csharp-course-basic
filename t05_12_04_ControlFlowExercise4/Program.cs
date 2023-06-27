namespace t05_12_04_ControlFlowExercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program that picks a random number between 1 and 10.
            // Give the user 4 chances to guess the number.
            // If the user guesses the number, display "You won"; otherwise, display "You lost".
            // (To make sure the program is behaving correctly, you can display the secret number on the console first.)

            int random = new Random().Next(1, 10);
            int attempts = 4;

            while (attempts > 0)
            {
                Console.Write("Guess a number or type \"e\" to exit: ");
                var input = Console.ReadLine();

                if (int.TryParse(input, out int number))
                {
                    attempts--;
                    if (number == random)
                    {
                        Console.WriteLine("You won");
                        System.Environment.Exit(0);
                    }
                    if (attempts > 0)
                    {
                        Console.WriteLine($"You have {attempts} attempts left.");
                    }
                    Console.WriteLine();
                }
                else if (input?.Trim().ToLower() == "e")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong input.");
                }
            }
            Console.WriteLine("You lost");
            Console.WriteLine($"Random number was {random}.");
        }
    }
}