using System;

namespace CalculatorSqure
{
    public class Triangle : Shape
    {

        public double ab { get; private set; }
        public double bc { get; private set; }
        public double ca { get; private set; }
        public string FigureName { get; set; }

        public Triangle(string FigureName, double ab, double bc, double ca)
        {
            this.FigureName = FigureName;
            if (IsCorrectValue(ab, bc, ca)) throw new ArgumentException("Inorrect values");
            else
            {
                this.ab = ab;
                this.bc = bc;
                this.ca = ca;
            }
        }

        public double CalcSquare()
        {
            var semiPerimeter = (ab + bc + ca) / 2;
            var result = Math.Round(Math.Sqrt(
                semiPerimeter *
                (semiPerimeter - ab) *
                (semiPerimeter - bc) *
                (semiPerimeter - ca)), 1);
            return result;
        }

        public bool IsRectangular()
        {
            var isRectangular = (ab == Math.Sqrt(Math.Pow(bc, 2) + Math.Pow(ca, 2))
                         || bc == Math.Sqrt(Math.Pow(ab, 2) + Math.Pow(ca, 2))
                         || ca == Math.Sqrt(Math.Pow(ab, 2) + Math.Pow(bc, 2)));
            return isRectangular;
        }

        public bool IsCorrectValue(double ab, double bc, double ca)
        {
            return ab < 0 || bc < 0 || ca < 0 || ab > (bc + ca) || bc > (ab + ca) || ca > (ab + bc) ?
                 true : false;


        }
    }
}
