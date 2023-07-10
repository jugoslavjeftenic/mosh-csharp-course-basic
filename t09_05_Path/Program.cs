namespace t09_05_Path
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = @"E:\SDK-github\course-mosh\c# 1 - basic\t09_05_Path\Program.cs";

            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);
            Console.WriteLine(extension);

            Console.WriteLine($"Extension: {Path.GetExtension(path)}");
            Console.WriteLine($"File name without of wxtension: {Path.GetFileNameWithoutExtension(path)}");
            Console.WriteLine($"File name: {Path.GetFileName(path)}");
            Console.WriteLine($"Directory name: {Path.GetDirectoryName(path)}");
        }
    }
}