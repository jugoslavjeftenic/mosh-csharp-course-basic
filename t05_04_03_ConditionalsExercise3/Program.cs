namespace t05_04_03_ConditionalsExercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program and ask the user to enter the width and height of an image.
            // Then tell if the image is landscape or portrait.

            Console.WriteLine("Please enter width of an image:");
            if (!int.TryParse(Console.ReadLine(), out int width))
            {
                WrongInput();
            }

            Console.WriteLine("Please enter height of an image:");
            if (!int.TryParse(Console.ReadLine(), out int height))
            {
                WrongInput();
            }

            if (width < 1 || height < 1)
            {
                WrongInput();
            }

            if (width > height)
            {
                Console.WriteLine("Your image is in landscape mode.");
            }
            else if (width < height)
            {
                Console.WriteLine("Your image is in portait mode.");
            }
            else
            {
                Console.WriteLine("Your image has equal heigt and width.");
            }
        }

        internal static void WrongInput()
        {
            Console.WriteLine("Wrong input. Please enter number that is greater then 0.");
            System.Environment.Exit(13);
        }
    }
}