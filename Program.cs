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
            int n = int.Parse(Console.ReadLine());

double minLength = double.MaxValue;
double[] shortestVector = null;

for (int i = 0; i < n; i++)
{
    double[] v = Console.ReadLine()
        .Split(' ')
        .Select(double.Parse)
        .ToArray();

    double length = Math.Sqrt(
        v[0] * v[0] +
        v[1] * v[1] +
        v[2] * v[2]
    );

    if (length < minLength)
    {
        minLength = length;
        shortestVector = v;
    }
}

Console.WriteLine($"Shortest length: {minLength}");
Console.WriteLine("Vector: " + string.Join(" ", shortestVector));
        }
    }
}
