namespace AreaCalculator.AreaCalculators
{
    internal class Triangle : BaseFigure
    {
        private double _side1;
        private double _side2;
        private double _side3;
        private bool _isRightTriangle;

        public Triangle(double side1, double side2, double side3)
        {
            _side1 = Math.Max(side1, Math.Max(side2, side3));

            if (_side1 == side1)
            {
                _side2 = side2;
                _side3 = side3;
            }
            else if (_side1 == side2)
            {
                _side2 = side1;
                _side3 = side3;
            }
            else
            {
                _side2 = side1;
                _side3 = side2;
            }

            if (!IsValidFigure())
                throw new ArgumentException("Треугольник с такими сторонами не может существовать.");

            _isRightTriangle = IsRightTriangle();
        }

        private bool IsValidFigure()
        {
            if (_side2 <= 0 || _side3 <= 0 || _side1 <= 0)
                return false;
            return _side2 + _side3 > _side1 &&
                   _side2 + _side1 > _side3 &&
                   _side3 + _side1 > _side2;
        }

        override public double Area()
        {
            if (_isRightTriangle){
                return CalculateAreaForRightTriangle();
            }
            else
            {
                return CalculateAreaForAnyTriangle();
            }
        }

        private bool IsRightTriangle()
        {
            return Math.Abs(Math.Pow(_side1, 2) - (Math.Pow(_side2, 2) + Math.Pow(_side3, 2))) < 1e-10;
        }

        private double CalculateAreaForRightTriangle()
        {
            return 0.5 * _side2 * _side3;
        }

        private double CalculateAreaForAnyTriangle()
        {
            var pHalf = (_side1 + _side2 + _side3) / 2;
            return Math.Sqrt(pHalf * (pHalf - _side1) * (pHalf - _side2) * (pHalf - _side3));
        }
    }
}
