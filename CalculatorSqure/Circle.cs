using System;

namespace CalculatorSqure
{
    public class Circle : Shape
    {
        public double Radius { get; private set; }
        public string FigureName { get; set; }

        public Circle(string FigureName, double Radius)
        {
            this.Radius = Radius;
            this.FigureName = FigureName;
        }

        public double CalcSquare()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), 1);
        }
    }
}
