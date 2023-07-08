using System.Text;

namespace t08_08_04_WorkingWithTextExercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program and ask the user to enter a few words separated by a space.
            // Use the words to create a variable name with PascalCase.
            // For example, if the user types: "number of students", display "NumberOfStudents".
            // Make sure that the program is not dependent on the input.
            // So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".

            Console.WriteLine("Enter a few words separated by a space:");
            var input = Console.ReadLine();
            if (input == null || input.Length < 1)
            {
                Console.WriteLine("Invalid input. Please re-try.");
                System.Environment.Exit(13);
            }

            var words = input.Split(' ');
            if (words != null || words?.Length > 0)
            {
                var stringBuilder = new StringBuilder();
                foreach (var word in words)
                {
                    stringBuilder.Append(char.ToUpper(word[0]));
                    if (word.Length > 1)
                    {
                        stringBuilder.Append(word[1..].ToLower());
                    }
                }
                Console.WriteLine(stringBuilder);
            }
        }
    }
}