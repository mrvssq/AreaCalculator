using AreaCalculator.AreaCalculators;

namespace AreaCalculator.Helpers
{
    public static class AreaCalcHelper
    {
        public static double Circle(double val1)
        {
            var circle = new Circle(val1);
            return circle.Area();
        }

        public static double Triangle(double val1, double val2, double val3)
        {
            var triangle = new Triangle(val1, val2, val3);
            return triangle.Area();
        }

        public static double Recognize(double[] vals)
        {
            if (vals.Length == 0)
                throw new ArgumentException("Не найдено ни одного параметра");

            if (vals.Length == 1)
                return AreaCalcHelper.Circle(vals[0]);

            if (vals.Length == 3)
                return AreaCalcHelper.Triangle(vals[0], vals[1], vals[2]);

            throw new ArgumentException("Распознать фигуру по входным данным не удалось");
        }
    }
}
