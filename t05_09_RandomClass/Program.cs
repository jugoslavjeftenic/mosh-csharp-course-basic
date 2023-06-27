namespace t05_09_RandomClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.Write(random.Next());
                Console.Write(":");
                Console.Write(random.Next(10));
                Console.Write(":");
                Console.Write(random.Next(1, 10));
                Console.Write(":");
                Console.WriteLine((char)random.Next(97, 122));
            }

            const int passwordLength = 20;
            var buffer = new char[passwordLength];
            for (int i = 0; i < passwordLength; i++)
            {
                buffer[i] = (char)('a' + random.Next(0, 26));
            }
            var password = new string(buffer);
            Console.WriteLine(password);
        }
    }
}