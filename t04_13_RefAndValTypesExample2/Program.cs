namespace t04_13_RefAndValTypesExample2
{
    internal class Pearson
    {
        internal int Age;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var number = 1;
            Increment(number);
            Console.WriteLine(number);

            var pearson = new Pearson() { Age = 20 };
            MakeOld(pearson);
            Console.WriteLine(pearson.Age);
        }

        internal static void Increment(int number)
        {
            number += 10;
        }

        internal static void MakeOld(Pearson pearson)
        {
            pearson.Age += 10;
        }
    }
}