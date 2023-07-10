using System.Text;

namespace t09_04_DirectoryAndDirectoryInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Directory - static method
            var directory = @"E:\SDK-github\course-mosh\c# 1 - basic\t09_04_DirectoryAndDirectoryInfo\CreatedDirectory";
            Directory.CreateDirectory(directory);

            string[] files = Directory.GetFiles(
                @"E:\SDK-github\course-mosh\c# 1 - basic\t09_04_DirectoryAndDirectoryInfo",
                "*.*",
                SearchOption.TopDirectoryOnly);
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }

            Console.WriteLine(new StringBuilder().Append('-', 10));

            string[] directories = Directory.GetDirectories(
                @"E:\SDK-github\course-mosh\c# 1 - basic\t09_04_DirectoryAndDirectoryInfo",
                "*.*",
                SearchOption.TopDirectoryOnly);
            foreach (string dir in directories)
            {
                Console.WriteLine(dir);
            }

            // DirectoryInfo - instance method
            var directoryInfo = new DirectoryInfo(
                @"E:\SDK-github\course-mosh\c# 1 - basic\t09_04_DirectoryAndDirectoryInfo\CreatedDirectoryInfo");
            directoryInfo.Create();
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();
        }
    }
}