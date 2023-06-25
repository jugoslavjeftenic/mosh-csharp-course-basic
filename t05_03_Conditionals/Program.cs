namespace t05_03_Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = 10;
            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning.");
            }
            else if (hour > 11 && hour < 18)
            {
                Console.WriteLine("It's afternoon.");
            }
            else
            {
                Console.WriteLine("It's evening.");
            }

            bool isGoldCustomer = true;
            float price;
            if (isGoldCustomer)
            {
                price = 19.95F;
            }
            else
            {
                price = 29.95F;
            }
            Console.WriteLine(price);

            price = (isGoldCustomer) ? 19.95F : 29.95F;
            Console.WriteLine(price);

            var season = Season.Autmun;
            switch (season)
            {
                case Season.Autmun:
                    Console.WriteLine("It's autmun and a beutiful season.");
                    break;
                case Season.Summer:
                    Console.WriteLine("It's summer and perfect time to go to beach.");
                    break;
                case Season.Spring:
                case Season.Winter:
                    Console.WriteLine("We've got promotion");
                    break;
                default:
                    Console.WriteLine("I don't understand that season!");
                    break;
            }
        }
    }
}