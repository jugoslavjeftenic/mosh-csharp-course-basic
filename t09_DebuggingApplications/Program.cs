using System.Data;

namespace t09_DebuggingApplications
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // F5        - run debugg mode
            // Shift F5  - exit debugg mode
            // F9        - break point
            // F10       - step over
            // F11       - step into
            // Shift F11 - step out

            var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            var smallests = GetSmallests(numbers, 3);

            foreach (var number in smallests)
                Console.WriteLine(number);
        }

        public static List<int> GetSmallests(List<int> list, int count)
        {
            if (list == null)
            {
                throw new ArgumentNullException("list");
            }

            if (count > list.Count || count < 1)
            {
                throw new ArgumentOutOfRangeException("count", "Count should be between 1 and the number of elements in the list.");
            }

            var buffer = new List<int>(list);
            var smallests = new List<int>();

            while (smallests.Count < count)
            {
                var min = GetSmallest(buffer);
                smallests.Add(min);
                buffer.Remove(min);
            }

            return smallests;
        }

        public static int GetSmallest(List<int> list)
        {
            // Assume the first number is the smallest
            var min = list[0];
            for (var i = 1; i < list.Count; i++)
            {
                if (list[i] < min)
                    min = list[i];
            }
            return min;
        }
    }
}