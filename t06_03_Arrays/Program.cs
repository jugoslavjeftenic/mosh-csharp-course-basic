namespace t06_03_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 3, 7, 9, 2, 14, 6 };

            Console.WriteLine("Length: " + numbers.Length);
            Console.WriteLine("Index of 9: " + Array.IndexOf(numbers, 9));
            Console.WriteLine();

            Array.Clear(numbers, 0, 2);
            Console.WriteLine("Effect of Clear()");
            foreach (var n in numbers)
            {
                Console.Write(n + ", ");
            }
            Console.WriteLine();
            Console.WriteLine();

            var anotherArray = new int[3];
            Array.Copy(numbers, 3, anotherArray, 0, 3);
            Console.WriteLine("Effect of Copy()");
            foreach (var n in anotherArray)
            {
                Console.Write(n + ", ");
            }
            Console.WriteLine();
            Console.WriteLine();

            Array.Sort(anotherArray);
            Console.WriteLine("Effect of Sort()");
            foreach (var n in anotherArray)
            {
                Console.Write(n + ", ");
            }
            Console.WriteLine();
            Console.WriteLine();

            Array.Reverse(anotherArray);
            Console.WriteLine("Effect of Reverse()");
            foreach (var n in anotherArray)
            {
                Console.Write(n + ", ");
            }
        }
    }
}