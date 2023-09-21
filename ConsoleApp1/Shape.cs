namespace CSharpOOPs_Application
{
    abstract class Shape
    {
        public abstract double Area();
    }
    class Circle : Shape
    {
        private readonly double radius;
        public Circle(double r)
        {
            radius = r;
        }
        public override double Area()
        {
            return (3.14 * radius * radius);
        }
    }
    class Square : Shape
    {
        private readonly double side;
        public Square(double s)
        {
            side = s;
        }
        public override double Area()
        {
            return (side * side);
        }
    }
    class Triangle : Shape
    {
        private readonly double tbase;
        private readonly double theight;
        public Triangle(double b, double h)
        {
            tbase = b;
            theight = h;
        }
        public override double Area()
        {
            return (0.5 * tbase * theight);
        }
    }
}
