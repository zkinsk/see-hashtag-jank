using System;

namespace CSharpIntermediate
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(Point newPoint)
        {
            if (!(newPoint is object)) throw new ArgumentNullException("point can't be null");
            this.Move(newPoint.X, newPoint.Y);
        }
    }
}
