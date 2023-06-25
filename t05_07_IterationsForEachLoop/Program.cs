namespace t05_07_IterationsForEachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var name = "James Bond";

            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            Console.WriteLine("-----");

            foreach (var character in name)
            {
                Console.WriteLine(character);
            }

            Console.WriteLine("-----");

            var numbers = new int[] { 1, 2, 3, 4 };
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}