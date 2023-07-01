using System.ComponentModel;
using System.Linq.Expressions;

namespace t06_06_01_ArraysAndListsExercise1
{
    internal class Program
    {
        static void Main()
        {
            // When you post a message on Facebook, depending on the number of people who like your post,
            // Facebook displays different information.
            // - If no one likes your post, it doesn't display anything.
            // - If only one person likes your post, it displays: [Friend's Name] likes your post.
            // - If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
            // - If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People]
            //   others like your post.

            // Write a program and continuously ask the user to enter different names,
            // until the user presses Enter(without supplying a name).
            // Depending on the number of names provided, display a message based on the above pattern.

            var names = new List<String>();

            while (true)
            {
                Console.Write("Enter a name: ");
                var input = Console.ReadLine()?.Trim();

                if (input == null || input.Length == 0)
                {
                    break;
                }
                names.Add(input);
            }

            switch (names.Count)
            {
                case 0:
                    break;
                case 1:
                    Console.WriteLine(names[0]);
                    break;
                case 2:
                    Console.WriteLine($"{names[0]}, {names[1]}");
                    break;
                default:
                    Console.WriteLine($"{names[0]}, {names[1]} [Other People: {names.Count - 2}]");
                    break;
            }
        }
    }
}