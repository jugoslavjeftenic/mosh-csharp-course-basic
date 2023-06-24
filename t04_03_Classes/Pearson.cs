namespace t04_03_Classes
{
    public class Pearson
    {
        public string? FirstName;
        public string? LastName;

        public void Introduce()
        {
            Console.WriteLine($"My name is {LastName}, {FirstName} {LastName}.");
        }
    }
}