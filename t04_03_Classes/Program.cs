using t04_03_Classes.Math;

namespace t04_03_Classes
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Pearson james = new()
            {
                FirstName = "James",
                LastName = "Bond"
            };
            james.Introduce();

            Calculator calculator = new();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);
        }
    }
}