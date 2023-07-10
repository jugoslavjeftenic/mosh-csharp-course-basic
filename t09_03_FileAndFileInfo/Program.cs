namespace t09_03_FileAndFileInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // File - static method
            string originalFile = @"E:\SDK-github\course-mosh\c# 1 - basic\t09_03_FileAndFileInfo\CSharpRoadMap.pdf";
            string copyToFile = @"E:\SDK-github\course-mosh\c# 1 - basic\t09_03_FileAndFileInfo\CopyOfCSharpRoadMap.pdf";

            File.Copy(originalFile, copyToFile,true);
            File.Delete(copyToFile);

            if (File.Exists(copyToFile))
            {
                Console.WriteLine("File found!");
            }
            else
            {
                Console.WriteLine("File not found!");
            }

            string txtFile = @"E:\SDK-github\course-mosh\c# 1 - basic\t09_03_FileAndFileInfo\someTxtFile.txt";
            File.Create(txtFile);

            var content = File.ReadAllText(@"E:\SDK-github\course-mosh\c# 1 - basic\t09_03_FileAndFileInfo\Program.cs");
            Console.WriteLine(content);
            Console.WriteLine();
            Console.WriteLine();

            // FileInfo - instance method
            Console.WriteLine("FileInfo");

            string fileProgramCs = @"E:\SDK-github\course-mosh\c# 1 - basic\t09_03_FileAndFileInfo\Program.cs";
            string copyOfFileProgramCs = @"E:\SDK-github\course-mosh\c# 1 - basic\t09_03_FileAndFileInfo\Program.txt";

            var fileInfo = new FileInfo(fileProgramCs);
            fileInfo.CopyTo(copyOfFileProgramCs);
            var copyOfFileInfo = new FileInfo(copyOfFileProgramCs);

            Console.WriteLine(copyOfFileInfo);

            if (copyOfFileInfo.Exists)
            {
                copyOfFileInfo.Delete();
            }
        }
    }
}