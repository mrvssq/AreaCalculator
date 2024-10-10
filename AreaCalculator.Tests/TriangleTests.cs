using AreaCalculator.Helpers;
using AreaCalculator.Tests.Helpers;

namespace AreaCalculator.Tests
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(3, 4, 5)]
        [InlineData(1200, 600, 800)]
        public void TestTriangle(double side1, double side2, double side3)
        {
            var exact = ExactTestAreaHelper.TriangleArea(side1, side2, side3);
            var value = AreaCalcHelper.Triangle(side1, side2, side3);
            Assert.Equal(exact, value);
        }

        [Theory]
        [InlineData(3, 4, 5)]
        [InlineData(1200, 600, 800)]
        public void TestUncnownRecognize(double side1, double side2, double side3)
        {
            var exact = ExactTestAreaHelper.TriangleArea(side1, side2, side3);
            var value = AreaCalcHelper.Recognize([side1, side2, side3]);
            Assert.Equal(exact, value);
        }

        [Fact]
        public void TestTriangleThrowExceptionWhenNegativeSide()
        {
            Assert.Throws<ArgumentException>(() => AreaCalcHelper.Triangle(-10, 5, 10)); // Отрицательная сторона
        }

        [Fact]
        public void TestTriangleThrowExceptionWhenWrongTriangle()
        {
            Assert.Throws<ArgumentException>(() => AreaCalcHelper.Triangle(2, 2, 100)); // Неверный треугольник
        }

        [Fact]
        public void TestUncnownWhenInvalidInput()
        {
            Assert.Throws<ArgumentException>(() => AreaCalcHelper.Recognize([2, 2])); // Недостаток параметров
        }

        [Fact]
        public void TestUncnownWhenUnrecognizedInput()
        {
            Assert.Throws<ArgumentException>(() => AreaCalcHelper.Recognize([2, 2, 2, 2])); // Лишние параметры
        }
    }
}