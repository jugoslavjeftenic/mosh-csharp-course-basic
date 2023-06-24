namespace t04_08_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Jugoslav";
            String lastName = "Jeftenic";

            var fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);

            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);
            Console.WriteLine(myFullName);

            var names = new string[3] { "John", "Jack", "Jill" };
            var formatedNames = string.Join(", ", names);
            Console.WriteLine(formatedNames);

            var text = "Hi John\nLook into the following paths\nc:\\folder1\\folder2\nc:\\folder3\\folder4";
            Console.WriteLine(text);

            var verbatimText = @"Hi John
Look into the following paths
c:\folder1\folder2
c:\\folder3\\folder4";
            Console.WriteLine(verbatimText);
        }
    }
}