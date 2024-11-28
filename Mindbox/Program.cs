using CalculatorSqure;
using System;

namespace Mindbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var triangle = new Triangle("Triangle", 7, 7, 8);
            var circle = new Circle("Circle", 102);

            Console.WriteLine(triangle.CalcSquare());
            Console.WriteLine(circle.CalcSquare());
        }
    }
}
