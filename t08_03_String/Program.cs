namespace t08_03_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Jugoslav Jeftenic ";
            Console.WriteLine($"Trim: \"{fullName.Trim()}\"");
            Console.WriteLine("Trim: \"{0}\"", fullName.Trim().ToUpper());

            Console.WriteLine("First name: \"{0}\"", fullName.Substring(0, fullName.IndexOf(' ')));
            Console.WriteLine("Last name: \"{0}\"", fullName.Substring(fullName.IndexOf(' ') + 1));

            var names = fullName.Split(' ');
            Console.WriteLine("First name: \"{0}\"", names[0]);
            Console.WriteLine("Last name: \"{0}\"", names[1]);

            Console.WriteLine("Replace string: \"{0}\"", fullName.Replace("Jugoslav", "Bomba"));
            Console.WriteLine("Replace char: \"{0}\"", fullName.Replace('J', 'B'));

            if (String.IsNullOrEmpty(null))
            {
                Console.WriteLine("String is null.");
            }
            if (String.IsNullOrEmpty(""))
            {
                Console.WriteLine("String is empty 1.");
            }
            if (String.IsNullOrEmpty(" ".Trim()))
            {
                Console.WriteLine("String is empty 2.");
            }
            if (String.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("String is empty 3.");
            }

            string input = "51";
            byte age = Convert.ToByte(input);
            Console.WriteLine(age);

            float price = 99.95f;
            Console.WriteLine(price.ToString("C"));
            Console.WriteLine(price.ToString("C2"));
        }
    }
}