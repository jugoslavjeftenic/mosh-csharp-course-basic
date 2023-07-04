using System.Text;

namespace t08_06_StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder();

            builder
                .Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10);

            builder.Replace('-', '+');

            builder.Remove(0, 10);

            builder.Insert(0, new string('-', 10));

            Console.WriteLine(builder);
            Console.WriteLine(builder[12]);
        }
    }
}