namespace t08_04_SummarisingText
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is going to be a really really really really really long text.";
            Console.WriteLine(StringUtility.SummerizeText(sentence));
        }
    }
}