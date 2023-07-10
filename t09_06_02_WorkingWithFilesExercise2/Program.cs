namespace t09_06_02_WorkingWithFilesExercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a text file and displays the longest word in the file.

            string textFile = @"E:\SDK-github\course-mosh\c# 1 - basic\t09_06_02_WorkingWithFilesExercise2\example.txt";

            if (File.Exists(textFile))
            {
                string text = File.ReadAllText(textFile);

                char[] delimiterChars = { ' ', ',', '.', ':', ';', '-', '\t' };
                string[] words = text.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);

                string longestWord = "";
                foreach (var word in words)
                {
                    if (word.Length > longestWord.Length)
                    {
                        longestWord = word;
                    }
                }

                Console.WriteLine($"Longest word is \"{longestWord}\".");
            }
        }
    }
}