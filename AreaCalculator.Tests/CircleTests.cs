using AreaCalculator.Helpers;
using AreaCalculator.Tests.Helpers;

namespace AreaCalculator.Tests
{
    public class CircleTests
    {
        [Theory]
        [InlineData(5)]
        [InlineData(2000)]
        public void TestCircle(double radius)
        {
            var exact = ExactTestAreaHelper.CircleArea(radius);
            var value = AreaCalcHelper.Circle(radius);
            Assert.Equal(exact, value);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(2000)]
        public void TestRecognize(double radius)
        {
            var exact = ExactTestAreaHelper.CircleArea(radius);
            var value = AreaCalcHelper.Recognize([radius]);
            Assert.Equal(exact, value);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(2000)]
        public void TestUncnownLikeCircle(double radius)
        {
            var exact = ExactTestAreaHelper.CircleArea(radius);
            var value = AreaCalcHelper.Recognize([radius], Enums.TypeOfFigure.Circle);
            Assert.Equal(exact, value);
        }

        [Fact]
        public void TestCircleThrowExceptionWhenNegativeRadius()
        {
            Assert.Throws<ArgumentException>(() => AreaCalcHelper.Circle(-10)); // ������������� ������
        }

        [Fact]
        public void TestUncnownWhenInvalidInput()
        {
            Assert.Throws<ArgumentException>(() => AreaCalcHelper.Recognize([], Enums.TypeOfFigure.Circle)); // ���������� ����������
        }

        [Fact]
        public void TestUncnownWhenUnrecognizedInput()
        {
            Assert.Throws<ArgumentException>(() => AreaCalcHelper.Recognize([10, 10], Enums.TypeOfFigure.Circle)); // ������ ���������
        }

        [Fact]
        public void TestUncnownWhenUnrecognizedInput2()
        {
            Assert.Throws<ArgumentException>(() => AreaCalcHelper.Recognize([10, 10])); // ������ ��������� ��� �������� ����
        }
    }
}