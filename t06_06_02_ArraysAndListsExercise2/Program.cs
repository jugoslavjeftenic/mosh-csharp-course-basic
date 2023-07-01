namespace t06_06_02_ArraysAndListsExercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program and ask the user to enter their name.
            // Use an array to reverse the name and then store the result in a new string.
            // Display the reversed name on the console.

            Console.Write("Enter your name: ");
            var input = Console.ReadLine()?.Trim();

            if (input?.Length > 0)
            {
                char[] charArray = input.ToCharArray();
                Array.Reverse(charArray);
                var reversedName = new string(charArray);
                Console.WriteLine(reversedName);
            }
        }
    }
}