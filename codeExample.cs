using System;
using System.Text;

namespace InterfaceExample
{
    public interface IShape
    {
        double Area();
        double Perimeter();
        int NumberOfSides();
    }

    public class Circle : IShape
    {
        private int x;
        private int y;
        private double radius;

        public Circle()
        {
            x = 1;
            y = 1;
            radius = 10;
        }

        public double Area()
        {
            return Math.PI * radius * radius;
        }

        public double Perimeter()
        {
            return Math.PI * 2 * radius;
        }

        public int NumberOfSides()
        {
            return 1;
        }
    }//end of Circle class

    public class Square : IShape
    {
        private int sideLength;

        public Square()
        {
            sideLength = 42;
        }

        public double Area()
        {
            return sideLength * sideLength;
        }

        public double Perimeter()
        {
            return 4.0 * sideLength;
        }

        public int NumberOfSides()
        {
            return 4;
        }

    }//end of Square class

    class TestInterface
    {
        static void Main(string[] args)
        {
            Circle myCircle = new Circle();
            Square mySquare = new Square();

            DisplayShapeInfo(myCircle);
            DisplayShapeInfo(mySquare);

            Console.ReadLine();
        }

        public static void DisplayShapeInfo(IShape myShape)
        {
            StringBuilder shapeInfo = new StringBuilder();
            string str;

            shapeInfo.Append("Shape Type " + myShape.GetType() + "\n\n");

            str = String.Format("Area: {0:F2}\n", myShape.Area());
            shapeInfo.Append(str);

            str = String.Format("Perimeter: {0:F2}\n", myShape.Perimeter());
            shapeInfo.Append(str);

            str = String.Format("Sides: {0:F2}\n", myShape.NumberOfSides());
            shapeInfo.Append(str);

            Console.WriteLine(shapeInfo.ToString() + "End of Shape: " +
                myShape.GetType() + "\n\n");
        }
    }
}
