using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t04_03_Classes
{
    internal class Pearson
    {
        public string? FirstName;
        public string? LastName;

        public void Introduce()
        {
            Console.WriteLine($"My name is {LastName}, {FirstName} {LastName}.");
        }
    }
}
