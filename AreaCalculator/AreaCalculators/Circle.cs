namespace AreaCalculator.AreaCalculators
{
    internal class Circle : BaseFigure
    {
        private double _radius;
        public Circle(double radius)
        {
            _radius = radius;
            if (!IsValidFigure())
                throw new ArgumentException("Окружность не может существовать с отрицательным радиусом.");
        }

        override public double Area()
        {
            return Math.PI * (_radius * _radius);
        }

        override protected bool IsValidFigure()
        {
            if (_radius <= 0)
                return false;
            return true;
        }
    }
}
