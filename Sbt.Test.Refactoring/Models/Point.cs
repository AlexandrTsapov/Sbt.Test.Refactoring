namespace Sbt.Test.Refactoring.Models
{
    public class Point
    {
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }

        public void TurnClockwise()
        {
            var x = X;
            X = -Y;
            Y = x;
        }

        public void TurnCounterclockwise()
        {
            var x = X;
            X = Y;
            Y = -x;
        }

        public Point Add(Point point)
        {
            X += point.X;
            Y += point.Y;

            return this;
        }

        public Point Subtract(Point point)
        {
            X -= point.X;
            Y -= point.Y;

            return this;
        }

        public override string ToString()
        {
            return $"{X},{Y}";
        }

        public override bool Equals(object obj)
        {
            return obj is Point point
                && X == point.X
                && Y == point.Y;
        }

        public static Point operator +(Point left, Point right)
        {
            return new Point(left.X + right.X, left.Y + right.Y);
        }

        public static Point operator -(Point left, Point right)
        {
            return new Point(left.X - right.X, left.Y - right.Y);
        }
    }
}
