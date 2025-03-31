namespace ShapeAreaCalculatorTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write subroutines to calculate the areas of 
            // Circle
            // Triangle
            // Rectangle
            // Pentagon
            // Octagon
        }
        static double AreaOfCircle(double radius)
        {
            return 3.1415 * radius * radius;
        }

        static double AreaOfTriangle(double baseLength, double height)
        {
            return 0.5 * baseLength * height;
        }

        static double AreaOfRectangle(double length, double width)
        {
            return length * width;
        }

        static double AreaOfPentagon(double sideLength, double apothem)
        {
            return (5 * sideLength * apothem) / 2;
        }

        static double AreaOfOctagon(double sideLength)
        {
            return 2 * (1 + Math.Sqrt(2)) * sideLength * sideLength;
        }

    }
}
