namespace t05_04_04_ConditionalsExercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Your job is to write a program for a speed camera.
            // For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic.
            // Write a program that asks the user to enter the speed limit.
            // Once set, the program asks for the speed of a car.
            // If the user enters a value less than the speed limit, program should display Ok on the console.
            // If the value is above the speed limit, the program should calculate the number of demerit points.
            // For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console.
            // If the number of demerit points is above 12, the program should display License Suspended.

            Console.WriteLine("Please enter a speed limit:");
            if (!int.TryParse(Console.ReadLine(), out int speedLimit))
            {
                WrongInput();
            }

            Console.WriteLine("Please enter a car speed:");
            if (!int.TryParse(Console.ReadLine(), out int carSpeed))
            {
                WrongInput();
            }

            if (speedLimit < 10 || carSpeed < 0)
            {
                WrongInput();
            }
        }

        internal static void WrongInput()
        {
            Console.WriteLine("Wrong input. Please enter a valid number.");
            System.Environment.Exit(13);
        }

        internal static void CheckInputs(int speedLimit, int carSpeed)
        {
            if(speedLimit < 10)
            {
                Console.WriteLine($"Wrong input. Please enter a speed limit that is 10 or greater.");
                System.Environment.Exit(13);
            }

            if(carSpeed < 1)
            {
                Console.WriteLine($"Wrong input. Please enter a speed limit that is 10 or greater.");
                System.Environment.Exit(13);
            }

        }
    }
}