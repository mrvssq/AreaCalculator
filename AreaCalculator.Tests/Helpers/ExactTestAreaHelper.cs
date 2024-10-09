namespace AreaCalculator.Tests.Helpers
{
    internal static class ExactTestAreaHelper
    {
        public static double CircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        public static double TriangleArea(double sida1, double side2, double side3)
        {
            var pHalf = (sida1 + side2 + side3) / 2;
            return Math.Sqrt(pHalf * (pHalf - sida1) * (pHalf - side2) * (pHalf - side3));
        }
    }
}
