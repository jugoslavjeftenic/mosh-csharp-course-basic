namespace t07_03_TimeSpan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var timeSpan1 = new TimeSpan(1, 2, 3);
            var timeSpan2 = new TimeSpan(1, 0, 0);
            var timeSpan3 = TimeSpan.FromHours(1);

            var startDate = DateTime.Now;
            var endDate = DateTime.Now.AddMinutes(2);
            var duration = endDate - startDate;
            Console.WriteLine($"Duration: {duration}");

            Console.WriteLine($"Minutes: {timeSpan1.Minutes}");
            Console.WriteLine($"Total minutes: {timeSpan1.TotalMinutes}");

            Console.WriteLine($"Add Example: {timeSpan1.Add(TimeSpan.FromMinutes(8))}");
            Console.WriteLine($"Subtrack Example: {timeSpan1.Subtract(TimeSpan.FromMinutes(2))}");

            Console.WriteLine($"ToString: {timeSpan1.ToString()}");
            Console.WriteLine($"Parse: {TimeSpan.Parse("01:02:03")}");
        }
    }
}