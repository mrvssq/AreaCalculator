using AreaCalculator.AreaCalculators;
using AreaCalculator.Enums;

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

        public static double Recognize(double[] vals, TypeOfFigure type = TypeOfFigure.Uncnown)
        {
            if (vals.Count() == 0)
                throw new ArgumentException("Не найдено ни одного параметра");

            switch (type)
            {
                case TypeOfFigure.Circle:
                    if (vals.Count() != 1)
                        throw new ArgumentException("Ошибка в параметрах для окружности");
                    return Circle(vals[0]);
                case TypeOfFigure.Triangle:
                    if (vals.Count() != 3)
                        throw new ArgumentException("Ошибка в параметрах для треугольника");
                    return Triangle(vals[0], vals[1], vals[2]);
                case TypeOfFigure.Uncnown:
                    return Recognizer(vals);
                default:
                    return 0;
            }
        }

        private static double Recognizer(double[] vals)
        {
            if (vals.Length == 1)
                return Circle(vals[0]);
            if (vals.Length == 3)
                return Triangle(vals[0], vals[1], vals[2]);
            throw new ArgumentException("Распознать фигуру по входным данным не удалось");
        }
    }
}
