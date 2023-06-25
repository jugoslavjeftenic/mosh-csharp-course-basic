namespace t05_04_02_ConditionalsExercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program which takes two numbers from the console and displays the maximum of the two.

            Console.WriteLine("Please enter first number:");
            if(!int.TryParse(Console.ReadLine(),out int num1))
            {
                WrongInput();
            }

            Console.WriteLine("Please enter second number:");
            if(!int.TryParse(Console.ReadLine(),out int num2))
            {
                WrongInput();
            }

            if(num1 < int.MinValue || num1 > int.MaxValue)
            {
                WrongInput();
            }

            if(num2 < int.MinValue || num1 > int.MaxValue)
            {
                WrongInput();
            }

            if(num1 > num2)
            {
                Console.WriteLine("First number is greater then second number.");
            }
            else if(num1 < num2)
            {
                Console.WriteLine("Second number is greater then first number.");
            }
            else
            {
                Console.WriteLine("Numbers are equal.");
            }
        }

        internal static void WrongInput()
        {
            Console.WriteLine($"Wrong input. Please enter number between {int.MinValue} and {int.MaxValue}.");
            System.Environment.Exit(13);
        }
    }
}