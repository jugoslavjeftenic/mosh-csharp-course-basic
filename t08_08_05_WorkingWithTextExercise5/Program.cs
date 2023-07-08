namespace t08_08_05_WorkingWithTextExercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program and ask the user to enter an English word.
            // Count the number of vowels (a, e, o, u, i) in the word.
            // So, if the user enters "inadequate", the program should display 6 on the console.

            Console.WriteLine("Enter an English word:");
            var input = Console.ReadLine();
            if (input == null || input.Length < 1)
            {
                Console.WriteLine("Invalid input. Please re-try.");
                System.Environment.Exit(13);
            }

            int total = input.Count(c => "aeiou".Contains(Char.ToLower(c)));
            Console.WriteLine($"Total vowel count: {total}");
        }
    }
}