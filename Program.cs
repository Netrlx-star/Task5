using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var v1 = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var v2 = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            if (v1.Length > v2.Length)
                Console.WriteLine("Longest vector: " + string.Join(" ", v1));
            else if (v2.Length > v1.Length)
                Console.WriteLine("Longest vector: " + string.Join(" ", v2));
            else
                Console.WriteLine("Vectors are of equal length.");

        }
    }
}
