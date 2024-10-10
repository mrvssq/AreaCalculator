namespace AreaCalculator.Helpers
{
    internal static class RecognizeHelper
    {
        public static double Recognizer(double[] vals)
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
