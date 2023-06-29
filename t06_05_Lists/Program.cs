namespace t06_05_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 2, 3, 4 };
            numbers.Add(1);
            numbers.AddRange(new int[3] { 5, 6, 7 });

            foreach (var n in numbers)
            {
                Console.Write(n + ", ");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Index of 1: " + numbers.IndexOf(1));
            Console.WriteLine("Last index of 1: " + numbers.LastIndexOf(1));

            Console.WriteLine("Count: " + numbers.Count);
            Console.WriteLine();

            numbers.Remove(1);
            foreach (var n in numbers)
            {
                Console.Write(n + ", ");
            }
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                {
                    numbers.Remove(numbers[i]);
                }
            }
            foreach (var n in numbers)
            {
                Console.Write(n + ", ");
            }
            Console.WriteLine();
            Console.WriteLine();

            numbers.Clear();
            Console.WriteLine("Count: " + numbers.Count);
        }
    }
}