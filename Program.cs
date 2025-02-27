using System;

namespace PointAndRectangle
{
    public enum PointColor
    {
        LightBlue,
        BloodRed,
        Gold
    }

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public PointColor Color { get; set; }

        public Point(int x, int y, PointColor color)
        {
            X = x;
            Y = y;
            Color = color;
        }

        public void DisplayStatus()
        {
            Console.WriteLine($"Point({X}, {Y}) - Color: {Color}");
        }
    }

    public class Rectangle
    {
        public Point TopLeft { get; set; }
        public Point BottomRight { get; set; }

        public Rectangle(Point topLeft, Point bottomRight)
        {
            TopLeft = topLeft;
            BottomRight = bottomRight;
        }

        public void DisplayStatus()
        {
            Console.WriteLine("Rectangle:");
            Console.WriteLine($"Top-left corner: ({TopLeft.X}, {TopLeft.Y}) - Color: {TopLeft.Color}");
            Console.WriteLine($"Bottom-right corner: ({BottomRight.X}, {BottomRight.Y}) - Color: {BottomRight.Color}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point topLeft = new Point(1, 5, PointColor.LightBlue);  
            Point bottomRight = new Point(6, 1, PointColor.BloodRed);  

            Rectangle rectangle = new Rectangle(topLeft, bottomRight);

            rectangle.DisplayStatus();

            Console.WriteLine("\nStatus of individual points:");
            topLeft.DisplayStatus();
            bottomRight.DisplayStatus();
        }
    }
}
