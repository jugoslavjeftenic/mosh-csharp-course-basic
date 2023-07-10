namespace t09_06_01_WorkingWithFilesExercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a text file and displays the number of words.

            string textFile = @"E:\SDK-github\course-mosh\c# 1 - basic\t09_06_01_WorkingWithFilesExercise1\example.txt";


            if (File.Exists(textFile))
            {
                string text = File.ReadAllText(textFile);
                char[] delimiterChars = { ' ', ',', '.', ':', ';', '-', '\t' };
                Console.WriteLine($"Number of words: {text.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries).Length}");
            }
        }
    }
}